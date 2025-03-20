namespace ArkPrac
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Dodaj = new Button();
            Usun = new Button();
            ZapisCSV = new Button();
            odczytCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(472, 307);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Dodaj
            // 
            Dodaj.Location = new Point(558, 86);
            Dodaj.Name = "Dodaj";
            Dodaj.Size = new Size(75, 23);
            Dodaj.TabIndex = 1;
            Dodaj.Text = "Dodaj";
            Dodaj.UseVisualStyleBackColor = true;
            Dodaj.Click += Dodaj_Click;
            // 
            // Usun
            // 
            Usun.Location = new Point(558, 139);
            Usun.Name = "Usun";
            Usun.Size = new Size(75, 23);
            Usun.TabIndex = 2;
            Usun.Text = "Usun";
            Usun.UseVisualStyleBackColor = true;
            Usun.Click += Usun_Click;
            // 
            // ZapisCSV
            // 
            ZapisCSV.Location = new Point(148, 347);
            ZapisCSV.Name = "ZapisCSV";
            ZapisCSV.Size = new Size(75, 42);
            ZapisCSV.TabIndex = 3;
            ZapisCSV.Text = "Zapisz do CSV";
            ZapisCSV.UseVisualStyleBackColor = true;
            ZapisCSV.Click += ZapisCSV_Click;
            // 
            // odczytCSV
            // 
            odczytCSV.Location = new Point(321, 347);
            odczytCSV.Name = "odczytCSV";
            odczytCSV.Size = new Size(76, 42);
            odczytCSV.TabIndex = 4;
            odczytCSV.Text = "Odczyt z CSV";
            odczytCSV.UseVisualStyleBackColor = true;
            odczytCSV.Click += odczytCSV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(odczytCSV);
            Controls.Add(ZapisCSV);
            Controls.Add(Usun);
            Controls.Add(Dodaj);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Dodaj;
        private Button Usun;
        private Button ZapisCSV;
        private Button odczytCSV;
    }
}
