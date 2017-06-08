using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor.Clear(); // czyścimy pole tekstowe
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() == DialogResult.OK) // jeśli wszystko w otwieraniu pliku przebiegło pomyślnie
            {
                TextEditor.LoadFile(openFile.FileName); // wczytaj plik korzystając z wbudowanej metody LoadFile

            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFile.ShowDialog() == DialogResult.OK) // jeśli wszystko w zapisu pliku przebiegło pomyślnie
            {
                TextEditor.SaveFile(saveFile.FileName); // zapisz plik korzystając z SaveFile
            }
        }

        private void CutTool_Click(object sender, EventArgs e)
        {
            TextEditor.Cut(); // wytnij
        }

        private void CopyTool_Click(object sender, EventArgs e)
        {
            TextEditor.Copy(); // kopiuj
        }

        private void PasteTool_Click(object sender, EventArgs e)
        {
            TextEditor.Paste(); // wklej
        }

        private void FontTool_Click(object sender, EventArgs e)
        {
            font.ShowDialog(); // pokaż dialog wybioru czcionek, metoda ShowDialog wyświetla okienko dialogowe, tj. nie będzie można powrócić do głównego okna bez zamknięcia tego co wyskoczyło
            TextEditor.Font = font.Font; // ustaw czcionke po zamknięciu okienka dialogowego
        }
    }
}
