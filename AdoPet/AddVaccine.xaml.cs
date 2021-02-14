using AdoPet.Classes;
using System;
using System.Collections.Generic;
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
using System.Data;

namespace AdoPet
{
    /// <summary>
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class AddVaccine : Window
    {
        public Animal selectedAnimal { get; set; }
        public AddVaccine(Animal animal)
        {
            InitializeComponent();
            cbVaccine.ItemsSource = Utils.LoadVaccines();
            cbVaccine.DisplayMemberPath = "Name";
            cbVaccine.SelectedValuePath = "ID";
            selectedAnimal = animal;
            txbNameSelectedPet.Text = animal.Name;
            dgPetVaccines.ItemsSource = Utils.LoadPetVaccines(selectedAnimal.ID);
            dgPetVaccines.AutoGeneratingColumn += dgPetVaccines_AutoGeneratingColumn;
        }

        private void dgPetVaccines_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Visibility = Visibility.Collapsed;
        }

        private void dpVaccinesDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            PetVaccine selectedVaccine = (PetVaccine)cbVaccine.SelectedItem;
            DateTime dateNextVaccine = ((DateTime)dpVaccinesDate.SelectedDate).AddMonths(selectedVaccine.ValidInMonths);
            txtDateNextVaccine.Text = dateNextVaccine.ToString("dd/MM/yyyy");
        }

        private void btnAddVacine_Click(object sender, RoutedEventArgs e)
        {
            PetVaccine selectedVaccine = (PetVaccine)cbVaccine.SelectedItem;
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            string query = @"INSERT INTO AnimalVaccines (VaccineID, AnimalID, Comment, InoculationDate) VALUES (@vaccineid, @animalid,@comment, @inoculationdate)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@vaccineid", SqlDbType.Int ){Value= selectedVaccine.ID},
                new SqlParameter("@animalid", SqlDbType.Int ){Value= selectedAnimal.ID},
                new SqlParameter("@comment", SqlDbType.NVarChar ){Value= txtComments.Text},
                new SqlParameter("@inoculationdate", SqlDbType.DateTime){Value=(DateTime)(dpVaccinesDate.SelectedDate)}
            };
            dataBase.ExecuteQuery(query, sqlParameters);
            MessageBox.Show("Pomyślnie dodano szczepienie");
            refreshVaccines();
        }
        public void refreshVaccines()
        {
            List<AnimalVaccinesViewModel> refreshedList = Utils.LoadPetVaccines(selectedAnimal.ID);
            dgPetVaccines.ItemsSource = refreshedList;

        }
    }
}
