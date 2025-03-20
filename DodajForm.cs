using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkPrac
{
    public partial class DodajForm : Form
    {

        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }

        public string Stanowisko { get; private set; }
        
        public DodajForm()
        {
            InitializeComponent();
            comboBoxStanowisko.Items.Add("Programista");
            comboBoxStanowisko.Items.Add("Tester");
            comboBoxStanowisko.Items.Add("Administrator");
            comboBoxStanowisko.SelectedIndex = 0;
        }

        private void textImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textImie.Text) || string.IsNullOrWhiteSpace(textNazwisko.Text) || !int.TryParse(textWiek.Text, out int wiek) || wiek <= 0)
            {
                MessageBox.Show("Wypelnij pola poprawnie", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                

            }

            Imie = textImie.Text;
            Nazwisko = textNazwisko.Text;
            Wiek =  int.Parse(textWiek.Text);
            Stanowisko = comboBoxStanowisko.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();


        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
