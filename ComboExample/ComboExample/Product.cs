using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboExample
{
    public class Product
    {
        public string Name { get; set; } // pola naszej klasy
        public string Value { get; set; }

        public override string ToString() // przesłonięta metoda wirtualna ToString()
        {
            return Name; // zwraca pole Name klasy
        }
    }
}
