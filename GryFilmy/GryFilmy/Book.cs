using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryFilmy
{
    public class Book : Product // Book dziedziczy z Product
    {
        public string Author { get; set; } // Autor
        public string PublishingHouse { get; set; } // Wydawnictwo
        public int NumberOfPages { get; set; } // Ilość stron
    }
}
