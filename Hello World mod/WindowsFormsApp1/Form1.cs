using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int counter = 0; // ustalamy sobie nasz licznik

        public Form1()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, EventArgs e) // wydarzenie, które nastąpi po naciśnięciu przycisku myButton
        {
            MessageBox.Show(textBox1.Text, "Zajęcia z WinForms", MessageBoxButtons.OK, MessageBoxIcon.Information); // wyświetli MessageBox, o tekście takim jak w textBox1(patrz pole .Text)
            counter++; // inkrementuje licznik
            timesClicked.Text = counter.ToString(); // ustala pole .Text labela na nasz licznik, oczywiście on jest typu int a pole .Text przyjmuje string, stąd skorzystanie z metody .ToString()
        }

        private void disableTextBox_CheckedChanged(object sender, EventArgs e) // zdarzenie które nastąpi po "zaptaszkowaniu" bądź "odptaszkowaniu" CheckBoxa o nazwie disableTextBox
        {
            if(disableTextBox.Checked) // jeśli jest "zaptaszkowany"
            {
                textBox1.Enabled = false; // wyłącza textBox1 odwołując się do jego pola Enabled(które jest boolem)
            }
            else // jeśli jest "odptaszkowany"
            {
                textBox1.Enabled = true; // to textBox1 jest włączony
            }
        }

        private void myOtherButton_Click(object sender, EventArgs e) // event który nastąpi po naciśnięciu myOtherButton
        {
            myButton.Text = textBox1.Text; // ustala tekst myButton na tekst textBox1
        }
    }
}
