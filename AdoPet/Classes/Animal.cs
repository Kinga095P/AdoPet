using System;
using System.Collections.Generic;
using System.Text;

namespace AdoPet
{
    public class Animal
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Sex { get; set; }
        public int Weight { get; set; }
        public int Activity { get; set; }
        public int Size { get; set; }
        public bool Vaccines { get; set; }
        public bool Sterilization { get; set; }
        public bool ChildFriendly { get; set; }
        public bool Trained { get; set; }
        public bool AcceptCats { get; set; }
        public bool AcceptDogs { get; set; }
    }
}
