using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetBtn_Click(object sender, EventArgs e) // event na kliknięcie przycisku ustaw
        {
            Product newProduct = new Product(); // nowy obiekt typu Product
            newProduct.Name = Header.Text; // ustawienie jego pól na to co wklepał użytkownik do komponentów textbox
            newProduct.Value = Value.Text;
            combo.Items.Add(newProduct); // dodanie naszego obiektu do listy rozwijanej typu comboBox
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e) // event na wybór pozycji z listy rozwijanej combo
        {
            string currentlySelected = combo.SelectedItem.ToString(); // pobiera zaznaczoną pozycje
            foreach(Product item in combo.Items) // przeszukuje kolekcje itemów w liście rozwijanej typu Product
            {
                if(item.Name.Equals(currentlySelected)) // jeśli pole Name znalezionego obiektu jest równe z nazwą zaznaczonego elementu na liście to
                {
                    MessageBox.Show(item.Value); // pokaż jego pole Value czyli wartość
                }
            }
        }
    }
}
