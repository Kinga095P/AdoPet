using System;
using System.Collections.Generic;
using System.Text;

namespace AdoPet
{
    public class AnimalVaccinesViewModel
    {
        public int VaccineID { get; set; }
        public int AnimalId { get; set; }
        public string Comment { get; set; }
        public string NameVaccine { get; set; }
        public DateTime InoculationDate { get; set; }
        public int ValidInMonths { get; set; }

        public DateTime ValidityDate 
        {
            get
            {
                return InoculationDate.AddMonths(ValidInMonths);
            }
        }

    }
}
