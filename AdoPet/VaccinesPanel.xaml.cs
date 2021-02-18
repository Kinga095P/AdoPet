using AdoPet.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AdoPet
{
    /// <summary>
    /// Interaction logic for Vaccine.xaml
    /// </summary>
    public partial class VaccinesPanel : Window
    {
        public int EditedID { get; set; }
        
        public VaccinesPanel()
        {
            InitializeComponent();
            RefreshVaccines();
            dgVaccines.AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
            dgVaccines.CanUserAddRows = false;

        }
        private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Visibility = Visibility.Collapsed;
        }
        
        public void RefreshVaccines()
        {
            List<PetVaccine> refreshedList = Utils.LoadVaccines();
            dgVaccines.ItemsSource = refreshedList;

        }
        public void ClearTextBox()
        {
            txtVaccine.Clear();
            txtMonth.Clear();
        }
        private void btnAddVaccine_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            
                if (string.IsNullOrEmpty(txtVaccine.Text))
                {
                    MessageBox.Show("Proszę podać nazwę szczepionki");
                }
                else if (string.IsNullOrEmpty(txtMonth.Text))
                {
                    MessageBox.Show("Proszę podać datę ważności szczepionki");
                }
                else
                {
                    DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
                    string query = @"INSERT INTO Vaccines (Name, ValidInMonths) VALUES (@name,@validinmonths)";
                    List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@name",SqlDbType.NVarChar){Value=txtVaccine.Text},
                new SqlParameter("@validinmonths", SqlDbType.Int){Value=int.Parse(txtMonth.Text)}
            };
                    dataBase.ExecuteQuery(query, sqlParameters);
                    RefreshVaccines();
                    ClearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd");
            }
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
         
            PetVaccine pv = (PetVaccine)dgVaccines.SelectedItem;
            txtVaccine.Text = pv.Name.ToString();
            txtMonth.Text = pv.ValidInMonths.ToString();
            EditedID = pv.ID;
 
        }

        private void lstVaccines_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PetVaccine pv = (PetVaccine)dgVaccines.SelectedItem;
            txtVaccine.Text = pv.Name;
            txtMonth.Text = pv.ValidInMonths.ToString();
            btnAddVaccine.Content = "Edytuj szczepienie";

        }

        private void btnEditVaccine_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtVaccine.Text))
                {
                    MessageBox.Show("Proszę podać nazwę szczepionki");
                }
                else if (string.IsNullOrEmpty(txtMonth.Text))
                {
                    MessageBox.Show("Proszę podać datę ważności szczepionki");
                }
                else
                {
                    DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
                    string query = @"UPDATE Vaccines SET Name=@name, ValidInMonths=@validinmonths WHERE ID=@id";
                    List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int){Value=EditedID},
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = txtVaccine.Text},
                new SqlParameter("@validinmonths", SqlDbType.Int) { Value = int.Parse(txtMonth.Text)}

            };
                    dataBase.ExecuteQuery(query, sqlParameters);
                    RefreshVaccines();
                    ClearTextBox();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd");
            }
        }

        private void btnDelete_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                PetVaccine pv = (PetVaccine)dgVaccines.SelectedItem;

               

                    DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
                    string query = @"UPDATE Vaccines SET RemovalDate=@removaldate WHERE ID=@id";
                    List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                    new SqlParameter("@id",SqlDbType.Int){Value=pv.ID},  
                    new SqlParameter("@removaldate", SqlDbType.DateTime){Value=DateTime.Now}

            };
                    dataBase.ExecuteQuery(query, sqlParameters);
                    RefreshVaccines();
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd");
            }
        }
    }
}
