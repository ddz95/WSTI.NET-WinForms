using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GryFilmy
{
    public partial class AddForm : Form // klasa naszej formy AddForm
    {
        // Tworzymy sobie obiekty typu Product, Game, Video, Book
        private Product product = new Product();
        private Game game = new Game();
        private Video video = new Video();
        private Book book = new Book();

        public AddForm(Product received) // Konstruktor tej formy, odbieramy tutaj obiekt, który został wysłany z formy głównej
        {
            InitializeComponent();

            product = received; // no i przypisujemy że produkt z tej formy to produkt odebrany, w ten sposób modyfikując go będzie on również zmieniony w formie głównej
            product.Game = game; // do jego pola Game dodajemy utworzony obiekt w tej formie
            product.Video = video; // w/w
            product.Book = book; // w/w
            // Skąd taka konstrukcja? No bo np product.Game to nic innego jak odwołanie do obiektu typu Game poprzez obiekt product, jeżeli byłby on pusty no to IDE miało by do nas problem
            // że najpierw trzeba utworzyć obiekt klasy
        }
        private void AddForm_Load(object sender, EventArgs e) // zdarzenie gdy ta forma jest włączana
        {
            // Za pomocą kodu do komponentu GameType, dodajemy itemy, tj. gatunki gier
            // Pokazuje to jak zrobić to za pomocą kodu, normalnie taki sam efekt osiągnęlibyśmy z poziomu Properties Window w [Design] tej formy
            // Dla zakładki Film/Książki jest to już zrobione z poziomu [Design] -> szukaj pola Items
            GameType.Items.Add("Akcja");
            GameType.Items.Add("Zręcznościowa");
            GameType.Items.Add("Bijatyka");
            GameType.Items.Add("RPG");
            GameType.Items.Add("Strategiczna");
            GameType.Items.Add("Przygodowa");
            GameType.Items.Add("Sportowa");
            GameType.Items.Add("Wyścigowa");
            GameType.Items.Add("Symulator");
            GameType.Items.Add("Logiczna");
            GameType.Items.Add("Towarzyska");
            GameType.Items.Add("MMO");
        }
        private void GameAdd_Click(object sender, EventArgs e) // event, gdy klikniemy przycisk w zakładce "Gra"
        {
            if (GameName.Text != "" && GameType.SelectedItem != null) // jeśli nazwa gry nie jest pusta oraz wybrano gatunek to
            {
                // wypełniamy pola produktu
                product.Game.Name = GameName.Text; // nazwę
                product.Game.Type = GameType.SelectedItem.ToString(); // gatunek
                product.Game.Price = GamePrice.Value; // cene
                product.Game.ReleaseDate = GameDateTime.Value; // date premiery
                product.Game.Producer = GameProducer.Text; // producenta
                product.Book = null; // nie jest to książka więc null
                product.Video = null; // ani film więc też null
                this.DialogResult = DialogResult.OK; // zwracamy rezultat pomyślny
                this.Close(); // zamykamy okno
            }
            else
                MessageBox.Show("Uzupełnij informacje!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void GameAdult_CheckedChanged(object sender, EventArgs e) // zmieniono wartość w komponencie z tekstem +18(checkbox) dla gier
        {
            if(GameAdult.Checked) // jeśli jest zaptaszkowany 
                product.Game.ForAdults = true; // to gra jest dla dorosłych
            else // jeśli jest odptaszkowany
                product.Game.ForAdults = false; // to jest bez ograniczeń wiekowych
        }

        // w pozostałych zdarzeniach dzieje się to samo co w przypadku gier, tylko precyzując dla ksiażki/filmu
        private void VideoAdd_Click(object sender, EventArgs e)
        {
            if (VideoName.Text != "" && VideoType.SelectedItem != null)
            {
                product.Video.Name = VideoName.Text;
                product.Video.Type = VideoType.SelectedItem.ToString();
                product.Video.Price = VideoPrice.Value;
                product.Video.ReleaseDate = VideoDateTime.Value;
                product.Video.Direction = VideoDirection.Text;
                product.Video.Scenario = VideoScenario.Text;
                product.Game = null;
                product.Book = null;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Uzupełnij informacje!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void VideoAdult_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoAdult.Checked)
                product.Video.ForAdults = true;
            else
                product.Video.ForAdults = false;
        }
        private void BookAdd_Click(object sender, EventArgs e)
        {
            if (BookName.Text != "" && BookType.SelectedItem != null)
            {
                product.Book.Name = BookName.Text;
                product.Book.Type = BookType.SelectedItem.ToString();
                product.Book.Price = BookPrice.Value;
                product.Book.ReleaseDate = BookDateTime.Value;
                product.Book.Author = BookAuthor.Text;
                product.Book.PublishingHouse = BookPubHouse.Text;
                product.Book.NumberOfPages = (int)BookPages.Value;
                product.Game = null;
                product.Video = null;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Uzupełnij informacje!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BookAdult_CheckedChanged(object sender, EventArgs e)
        {
            if (BookAdult.Checked)
                product.Book.ForAdults = true;
            else
                product.Book.ForAdults = false;
        }
    }
}
