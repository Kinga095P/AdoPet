using System;
using System.Collections.Generic;
using System.Text;

namespace AdoPet
{
    
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public double Weight { get; set; }
        public Pet ID { get; internal set; }

        public Pet()
        {

        }
    }
}
