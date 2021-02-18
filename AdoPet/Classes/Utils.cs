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
            var dane = dataBase.SelectQuery("SELECT * FROM Vaccines WHERE RemovalDate IS NULL");
            
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
        public static List<Animal> LoadAnimals(string query = "SELECT * FROM Animal", List<SqlParameter> parameters = null)
        {
            List<Animal> animalList = new List<Animal>();
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            var dane = dataBase.SelectQuery(query, parameters);
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
        public static List<Adoption> LoadAnimalsAdopter(string query = "SELECT * FROM Adoptions", List<SqlParameter> parameters = null)
        {
            List<Adoption> adopterList = new List<Adoption>();
            DataBase dataBase = new DataBase("LAPTOP-N5V21FUT\\SQLEXPRESS", "AdoPetDB");
            var dane = dataBase.SelectQuery(query, parameters);
            foreach (DataRow dr in dane)
            {
                Adoption adoption = new Adoption();
                adoption.DateAdoption = DateTime.Parse(dr["DateAdoption"].ToString());
                adoption.PetName = dr["PetName"].ToString();
                adoption.Name = dr["Name"].ToString();
                adoption.Surname = dr["Surname"].ToString();
                adoption.Address = dr["Address"].ToString();
                adoption.PhoneNumber = dr["PhoneNumber"].ToString();
                adoption.Email = dr["Email"].ToString();
                adopterList.Add(adoption);
            }
            return adopterList;
        }
    }
}
