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
        public VaccinesPanel()
        {
            InitializeComponent();
            RefreshVaccines();
        }

        public List<PetVaccine> LoadVaccines()
        {
            List<PetVaccine> vaccineList = new List<PetVaccine>();
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            var dane = dataBase.SelectQuery("SELECT * FROM Vaccines");
            foreach (DataRow dr in dane)
            {
                PetVaccine petvaccine= new PetVaccine();
                petvaccine.ID = int.Parse(dr["ID"].ToString());
                petvaccine.Name = dr["Name"].ToString();        
                petvaccine.ValidInMonths = int.Parse(dr["ValidInMonths"].ToString());
                vaccineList.Add(petvaccine);
            }
            return vaccineList;
        }
        public void RefreshVaccines()
        {
            List<PetVaccine> refreshedList = LoadVaccines();
            lstVaccines.ItemsSource = refreshedList;

        }
        private void btnAddVaccine_Click(object sender, RoutedEventArgs e)
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
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            PetVaccine pv = (PetVaccine)lstVaccines.SelectedItem;
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            string query = @"DELETE FROM Vaccines WHERE ID=@id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int){Value=pv.ID}
          
            };
            dataBase.ExecuteQuery(query, sqlParameters);
            RefreshVaccines();

           

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            PetVaccine pv = (PetVaccine)lstVaccines.SelectedItem;
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            string query = @"UPDATE Vaccines SET Name=@name, ValidInMonths=@validinmonths WHERE ID=@id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int){Value=pv.ID},
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = txtVaccine.Text},
                new SqlParameter("@validinmonths", SqlDbType.Int) { Value = txtMonth.Text}

            };
            dataBase.ExecuteQuery(query, sqlParameters);
            RefreshVaccines();
        }

        private void lstVaccines_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PetVaccine pv = (PetVaccine)lstVaccines.SelectedItem;
            txtVaccine.Text = pv.Name;
            txtMonth.Text = pv.ValidInMonths.ToString();
            btnAddVaccine.Content = "Edytuj szczepienie";
        }
    }
}
