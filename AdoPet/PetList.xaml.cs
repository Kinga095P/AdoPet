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
            dataGrid.ItemsSource = LoadAnimals();
            dataGrid.AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
        }

        private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Visibility = Visibility.Collapsed;
        }

        public List<Animal> LoadAnimals(string query= "SELECT * FROM Animal", List<SqlParameter> parameters=null)
        {
            List<Animal> animalList = new List<Animal>();
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            var dane = dataBase.SelectQuery(query,parameters);
            foreach (DataRow dr in dane)
            {
                Animal animal = new Animal(); 
                animal.ID = int.Parse(dr["ID"].ToString());
                animal.Type = dr["Type"].ToString();
                animal.Name = dr["Name"].ToString();
                animal.Age = int.Parse(dr["Age"].ToString());
                animal.Sex = int.Parse(dr["Sex"].ToString());
                animal.Weight = int.Parse(dr["Weight"].ToString());
                animal.Activity = int.Parse(dr["Activity"].ToString());
                animal.Vaccines = bool.Parse(dr["Vaccines"].ToString());
                animal.Sterilization = bool.Parse(dr["Sterilization"].ToString());
                animal.ChildFriendly = bool.Parse(dr["ChildFriendly"].ToString());
                animal.Trained = bool.Parse(dr["Trained"].ToString());
                animal.AcceptCats = bool.Parse(dr["AcceptCats"].ToString());
                animal.AcceptDogs = bool.Parse(dr["AcceptDogs"].ToString());
                animalList.Add(animal);
            }
            return animalList;
        }
        public void refreshAnimals()
        {
            List<Animal> refreshedList = LoadAnimals();
            dataGrid.ItemsSource = refreshedList;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPet addPet = new AddPet();
            addPet.Owner = this;
            addPet.ShowDialog();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
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

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Animal animal = (Animal)dataGrid.SelectedItem;
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            string query = @"DELETE FROM Animal WHERE ID=@id";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int){Value=animal.ID}
            };
            dataBase.ExecuteQuery(query, sqlParameters);
            refreshAnimals();
            MessageBox.Show("Usunięto zwierzę z bazy");
        }
       
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchQuery = "SELECT * FROM Animal WHERE LOWER(Name) LIKE @name";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
        {
            new SqlParameter("@name", SqlDbType.NVarChar){Value= "%" + txtSearch.Text.ToLower() + "%"}
        };
            List<Animal> searchedAnimals = LoadAnimals(searchQuery, sqlParameters);
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
            AdoptionDetails adoptionDetails = new AdoptionDetails();
            adoptionDetails.Owner = this;
            adoptionDetails.Show();
        }
    }

}
