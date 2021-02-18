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
    /// Interaction logic for AdoptionDetails.xaml
    /// </summary>
    public partial class AdoptionDetails : Window
    {
        public Animal selectedAnimal { get; set; }
        public AdoptionDetails(Animal animal)
        {

            InitializeComponent();
            selectedAnimal = animal;
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@name", SqlDbType.NVarChar){Value=selectedAnimal.Name}
            };
            dgDetails.ItemsSource = Utils.LoadAnimalsAdopter("SELECT * FROM Adoptions WHERE PetName=@name",sqlParameters);
            dgDetails.AutoGeneratingColumn += dgDetails_AutoGeneratingColumn;
            refreshAdopter();

        }
        private void dgDetails_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Visibility = Visibility.Collapsed;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void refreshAdopter()
        {
            List<Adoption> refreshedList = Utils.LoadAnimalsAdopter();
            dgDetails.ItemsSource = refreshedList;

        }
    }
}
