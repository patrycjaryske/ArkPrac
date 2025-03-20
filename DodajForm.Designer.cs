namespace ArkPrac
{
    partial class DodajForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textImie = new TextBox();
            textNazwisko = new TextBox();
            textWiek = new TextBox();
            label0 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            zatwierdz = new Button();
            Anuluj = new Button();
            comboBoxStanowisko = new ComboBox();
            SuspendLayout();
            // 
            // textImie
            // 
            textImie.Location = new Point(141, 81);
            textImie.Name = "textImie";
            textImie.Size = new Size(100, 23);
            textImie.TabIndex = 0;
            textImie.TextChanged += textImie_TextChanged;
            // 
            // textNazwisko
            // 
            textNazwisko.Location = new Point(141, 110);
            textNazwisko.Name = "textNazwisko";
            textNazwisko.Size = new Size(100, 23);
            textNazwisko.TabIndex = 1;
            // 
            // textWiek
            // 
            textWiek.Location = new Point(141, 139);
            textWiek.Name = "textWiek";
            textWiek.Size = new Size(100, 23);
            textWiek.TabIndex = 2;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Location = new Point(262, 85);
            label0.Name = "label0";
            label0.Size = new Size(30, 15);
            label0.TabIndex = 4;
            label0.Text = "Imie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 118);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 5;
            label1.Text = "Nazwisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 147);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Wiek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 176);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "Stanowisko";
            // 
            // zatwierdz
            // 
            zatwierdz.Location = new Point(153, 257);
            zatwierdz.Name = "zatwierdz";
            zatwierdz.Size = new Size(75, 23);
            zatwierdz.TabIndex = 8;
            zatwierdz.Text = "Zatwierdź";
            zatwierdz.UseVisualStyleBackColor = true;
            zatwierdz.Click += zatwierdz_Click;
            // 
            // Anuluj
            // 
            Anuluj.Location = new Point(262, 257);
            Anuluj.Name = "Anuluj";
            Anuluj.Size = new Size(75, 23);
            Anuluj.TabIndex = 9;
            Anuluj.Text = "Anuluj";
            Anuluj.UseVisualStyleBackColor = true;
            Anuluj.Click += Anuluj_Click;
            // 
            // comboBoxStanowisko
            // 
            comboBoxStanowisko.FormattingEnabled = true;
            comboBoxStanowisko.Location = new Point(135, 176);
            comboBoxStanowisko.Name = "comboBoxStanowisko";
            comboBoxStanowisko.Size = new Size(121, 23);
            comboBoxStanowisko.TabIndex = 10;
            // 
            // DodajForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxStanowisko);
            Controls.Add(Anuluj);
            Controls.Add(zatwierdz);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label0);
            Controls.Add(textWiek);
            Controls.Add(textNazwisko);
            Controls.Add(textImie);
            Name = "DodajForm";
            Text = "DodajForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textImie;
        private TextBox textNazwisko;
        private TextBox textWiek;
        private Label label0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button zatwierdz;
        private Button Anuluj;
        private ComboBox comboBoxStanowisko;
    }
}