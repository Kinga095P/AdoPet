using AdoPet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for PetList.xaml
    /// </summary>
    public partial class PetList : Window
    {
        private string _connectionString;

        public PetList()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Utils.LoadAnimals();
            dataGrid.AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
        }

        private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Visibility = Visibility.Collapsed;
        }

       
        public void refreshAnimals()
        {
            List<Animal> refreshedList = Utils.LoadAnimals();
            dataGrid.ItemsSource = refreshedList;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPet addPet = new AddPet();
            addPet.Owner = this;
            addPet.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchQuery = "SELECT * FROM Animal WHERE LOWER(Name) LIKE @name";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
        {
            new SqlParameter("@name", SqlDbType.NVarChar){Value= "%" + txtSearch.Text.ToLower() + "%"}
        };
            List<Animal> searchedAnimals = Utils.LoadAnimals(searchQuery, sqlParameters);
            dataGrid.ItemsSource = searchedAnimals;

        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(dataGrid, "My First Print Job");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Animal animal = (Animal)dataGrid.SelectedItem;
            AddVaccine addVaccine = new AddVaccine(animal);
            addVaccine.Owner = this;
            addVaccine.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Animal animal = (Animal)dataGrid.SelectedItem;
            AdoptionDetails adoptionDetails = new AdoptionDetails(animal);
            adoptionDetails.Owner = this;
            adoptionDetails.Show();
        }

        private void btnDelete_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Animal animal = (Animal)dataGrid.SelectedItem;
                DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
                string query = @"UPDATE Vaccines SET RemovalDate=@removaldate WHERE ID=@id";
                List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int){Value=animal.ID},
                new SqlParameter("@removaldate", SqlDbType.DateTime){Value=DateTime.Now}
            };
                dataBase.ExecuteQuery(query, sqlParameters);
                refreshAnimals();
                MessageBox.Show("Usunięto zwierzę z bazy");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd");
            }
            
        }

        private void btnEdit_Click_1(object sender, RoutedEventArgs e)
        {
            Animal animal = (Animal)dataGrid.SelectedItem;
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            string query = @"UPDATE Animal SET Type=@type, Name=@name, Age=@age, Sex=@sex, Weight=@weight, Activity=@activity, Size=@size, Vaccines=@vaccines, Sterilization=@sterilization, ChildFriendly=@childfriendly, Trained=@trained, AcceptCats=@acceptcats, AcceptDogs=@acceptdogs WHERE ID=@id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int){Value=animal.ID},
                new SqlParameter("@type", SqlDbType.NVarChar) { Value = animal.Type},
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = animal.Name},
                new SqlParameter("@age", SqlDbType.Int) { Value = animal.Age},
                new SqlParameter("@sex", SqlDbType.Int) { Value = animal.Sex},
                new SqlParameter("@weight", SqlDbType.Int) { Value = animal.Weight},
                new SqlParameter("@activity", SqlDbType.Int) { Value = animal.Activity},
                new SqlParameter("@size", SqlDbType.Int) { Value = animal.Size},
                new SqlParameter("@vaccines", SqlDbType.Bit) { Value = animal.Vaccines},
                new SqlParameter("@sterilization", SqlDbType.Bit) { Value = animal.Sterilization},
                new SqlParameter("@childfriendly", SqlDbType.Bit) { Value = animal.ChildFriendly},
                new SqlParameter("@trained", SqlDbType.Bit) { Value = animal.Trained},
                new SqlParameter("@acceptcats", SqlDbType.Bit) { Value = animal.AcceptCats},
                new SqlParameter("@acceptdogs", SqlDbType.Bit) { Value = animal.AcceptDogs}
            };
            dataBase.ExecuteQuery(query, sqlParameters);
            refreshAnimals();
            MessageBox.Show("Zwierzę zostało edytowane");
        }
    }

}
