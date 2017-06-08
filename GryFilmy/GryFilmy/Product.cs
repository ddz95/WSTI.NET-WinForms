using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization; // aby skorzystać z [XmlIgnore]

namespace GryFilmy
{
    [Serializable] // jest to atrybut, który świadczy o tym, że klasa ta może zostać serializowana
    public class Product // publiczna klasa Product
    {
        // Teraz pytanie, dlaczego w klasie głównej Product zawieram deklaracje obiektów innych klas?
        // A no klasa Product jest w tym przypadku uogólnieniem, ma 3 warianty: Game, Video, Book
        // W ten sposób możemy korzystać z następującej konstrukcji:
        // Product produkt = new Product();
        // produkt.Game = null;
        // produkt.Video = null;
        // produkt.Book.Name = "Książka";
        // Co świadczy o tym, że dany produkt jest książką, nie grą, nie filmem. 
        // Zrobiłem to po to, ponieważ później dany produkt jest przydzielany do odpowiedniej grupy do komponentu ProductList i łatwiej w ten sposób rozróżnić co jest czym

        public Game Game;
        public Video Video;
        public Book Book;

        // Z pól poniżej dziedziczą klasy Game, Video oraz Book
        public string Name { get; set; } // Nazwa produktu
        public string Type { get; set; } // Gatunek/Rodzaj
        public decimal Price { get; set; } // Cena
        public bool IsBorrowed { get; set; } // Czy wypożyczono
        public bool ForAdults { get; set; } // Czy jest to produkt przeznaczony dla dorosłych
        public DateTime ReleaseDate { get; set; } // Data premiery typu DateTime
        
    }
}
