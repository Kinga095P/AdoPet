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
    /// Interaction logic for AdoptionForm.xaml
    /// </summary>
    public partial class AdoptionForm : Window
    {
        public AdoptionForm()
        {
            InitializeComponent();
        }

        private void btnAdoption_Click(object sender, RoutedEventArgs e)
        {
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            string query = @"INSERT INTO Adoptions (DateAdoption, PetName, Name, Surname, Address, PhoneNumber, Email ) VALUES (@dateadoption, @petname, @name, @surname, @address, @phonenumber, @email)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@dateadoption", SqlDbType.DateTime){Value=DateTime.Parse(dpAdoptDate.SelectedDate.ToString())},
                new SqlParameter("@petname", SqlDbType.NVarChar){Value=txtPetToAdoption.Text},
                new SqlParameter("@name", SqlDbType.NVarChar){Value=txtName.Text},
                new SqlParameter("@surname", SqlDbType.NVarChar){Value=txtSurname.Text},
                new SqlParameter("@address", SqlDbType.NVarChar){Value=txtAddress.Text},
                new SqlParameter("@phonenumber", SqlDbType.NVarChar){Value=txtPhoneNumber.Text},
                new SqlParameter("@email", SqlDbType.NVarChar){Value=txtEmail.Text}

            };
            dataBase.ExecuteQuery(query, sqlParameters);
            MessageBox.Show("Pomyślnie dodano zwierzę do bazy");

           
        }
    }
}
