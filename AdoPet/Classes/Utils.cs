using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AdoPet.Classes
{
    public static class Utils
    {
        public static List<PetVaccine> LoadVaccines()
        {
            List<PetVaccine> vaccineList = new List<PetVaccine>();
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            var dane = dataBase.SelectQuery("SELECT * FROM Vaccines");
            foreach (DataRow dr in dane)
            {
                PetVaccine petvaccine = new PetVaccine();
                petvaccine.ID = int.Parse(dr["ID"].ToString());
                petvaccine.Name = dr["Name"].ToString();
                petvaccine.ValidInMonths = int.Parse(dr["ValidInMonths"].ToString());
                vaccineList.Add(petvaccine);
            }
            return vaccineList;
        }
        public static List<AnimalVaccinesViewModel> LoadPetVaccines(int AnimalID)
        {
            string query = @"SELECT Animal.ID AS AnimalID, Vaccines.ID AS VaccineID, AnimalVaccines.Comment, Vaccines.Name, Vaccines.ValidInMonths, AnimalVaccines.InoculationDate
            FROM AnimalVaccines
            JOIN Animal
            ON AnimalVaccines.AnimalID=Animal.ID
            JOIN Vaccines
            ON Vaccines.ID=AnimalVaccines.VaccineID
            WHERE Animal.ID=@ID";
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@ID", SqlDbType.Int ){Value= AnimalID}
            };
            List<AnimalVaccinesViewModel> petVaccineList = new List<AnimalVaccinesViewModel>();
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            var dane = dataBase.SelectQuery(query, sqlParameters);
            foreach (DataRow dr in dane)
            {
               AnimalVaccinesViewModel animalVaccinesViewModel= new AnimalVaccinesViewModel();
                animalVaccinesViewModel.InoculationDate = DateTime.Parse(dr["InoculationDate"].ToString());
                animalVaccinesViewModel.AnimalId = int.Parse(dr["AnimalID"].ToString());
                animalVaccinesViewModel.Comment = dr["Comment"].ToString();
                animalVaccinesViewModel.NameVaccine = dr["Name"].ToString();
                animalVaccinesViewModel.VaccineID= int.Parse(dr["VaccineID"].ToString());
                animalVaccinesViewModel.ValidInMonths= int.Parse(dr["ValidInMonths"].ToString());
                petVaccineList.Add(animalVaccinesViewModel);

            }
            return petVaccineList;
        }
    }
}
