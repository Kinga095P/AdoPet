using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddPet.xaml
    /// </summary>
    public partial class AddPet : Window
    {
        public AddPet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            string query = @"INSERT INTO Animal (Type, Name, Age, Sex, Weight, Activity, Size, Vaccines, Sterilization, ChildFriendly, Trained, AcceptCats, AcceptDogs ) VALUES (@type, @name, @age, @sex, @weight, @activity, @size, @vaccines, @sterilization, @childfriendly, @trained, @acceptcats, @acceptdogs)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@type",SqlDbType.NVarChar){Value=txtType.Text},
                new SqlParameter("@name", SqlDbType.NVarChar){Value=txtName.Text},
                new SqlParameter("@age", SqlDbType.Int){Value=int.Parse(txtAge.Text)},
                new SqlParameter("@sex", SqlDbType.Int){Value=Convert.ToInt32(((ComboBoxItem)cbSex.SelectedItem).Tag.ToString())},
                new SqlParameter("@weight", SqlDbType.Int){Value=int.Parse(txtWeight.Text)},
                new SqlParameter("@activity", SqlDbType.Int){Value=Convert.ToInt32(((ComboBoxItem)cbActivity.SelectedItem).Tag.ToString())},
                new SqlParameter("@size", SqlDbType.Int){Value=Convert.ToInt32(sizePet.Value)},
                new SqlParameter("@vaccines", SqlDbType.Bit){Value=(bool)cbVaccines.IsChecked ? 1:0},
                new SqlParameter("@sterilization", SqlDbType.Bit){Value=(bool)cbSterilization.IsChecked ? 1:0},
                new SqlParameter("@childfriendly", SqlDbType.Bit){Value=(bool)cbChildFriendly.IsChecked ? 1:0},
                new SqlParameter("@trained", SqlDbType.Bit){Value=(bool)cbTrained.IsChecked ? 1:0},
                new SqlParameter("@acceptcats", SqlDbType.Bit){Value=(bool)cbAcceptCats.IsChecked ? 1:0},
                new SqlParameter("@acceptdogs", SqlDbType.Bit){Value=(bool)cbAcceptDogs.IsChecked ? 1:0}
            };
            dataBase.ExecuteQuery(query, sqlParameters);
            MessageBox.Show("Pomyślnie dodano zwierzę do bazy");

            
        }
        
    }
}
