namespace ArkPrac
{
    public partial class Form1 : Form
    {
        private List<Pracownik> listaPracownikow = new List<Pracownik>();
        private int id = 1;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Imie";
            dataGridView1.Columns[2].Name = "Nazwisko";
            dataGridView1.Columns[3].Name = "Wiek";
            dataGridView1.Columns[4].Name = "Stanowisko";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            DodajForm dodajForm = new DodajForm();
            if (dodajForm.ShowDialog() == DialogResult.OK)
            {
                Pracownik nowyPracownik = new Pracownik
                {
                    ID = id++,
                    Imie = dodajForm.Imie,
                    Nazwisko = dodajForm.Nazwisko,
                    Wiek = dodajForm.Wiek,
                    Stanowisko = dodajForm.Stanowisko,

                };
                listaPracownikow.Add(nowyPracownik);

                dataGridView1.Rows.Add(nowyPracownik.ID, nowyPracownik.Imie, nowyPracownik.Nazwisko, nowyPracownik.Wiek, nowyPracownik.Stanowisko);
            }
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                listaPracownikow.RemoveAt(index);
                dataGridView1.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Wybierz wiersz do usuniecia!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class Pracownik
        {
            public int ID { get; set; }
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int Wiek { get; set; }
            public string Stanowisko { get; set; }
        }

        private void ZapisCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv"})
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (Pracownik p in listaPracownikow)
                        {
                            writer.WriteLine($"{p.ID};{p.Imie};{p.Nazwisko};{p.Wiek};{p.Stanowisko}");
                        }
                    }
                    MessageBox.Show("Dane zapisane do CSV!", "Sukces", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
            }
        }

        private void odczytCSV_Click(object sender, EventArgs e)
        {
            
        }
    }
}
