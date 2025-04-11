namespace dydelf
{
    partial class Ustawienia
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
            xTxt = new TextBox();
            yTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dydelfTxt = new TextBox();
            krokodylTxt = new TextBox();
            SzopTxt = new TextBox();
            CzasTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Zapisz = new Button();
            Anuluj = new Button();
            SuspendLayout();
            // 
            // xTxt
            // 
            xTxt.Location = new Point(82, 98);
            xTxt.Name = "xTxt";
            xTxt.Size = new Size(100, 23);
            xTxt.TabIndex = 0;
            // 
            // yTxt
            // 
            yTxt.Location = new Point(82, 165);
            yTxt.Name = "yTxt";
            yTxt.Size = new Size(100, 23);
            yTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 65);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Plansza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 106);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 173);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 4;
            label3.Text = "Y";
            // 
            // dydelfTxt
            // 
            dydelfTxt.Location = new Point(262, 98);
            dydelfTxt.Name = "dydelfTxt";
            dydelfTxt.Size = new Size(100, 23);
            dydelfTxt.TabIndex = 5;
            // 
            // krokodylTxt
            // 
            krokodylTxt.Location = new Point(262, 165);
            krokodylTxt.Name = "krokodylTxt";
            krokodylTxt.Size = new Size(100, 23);
            krokodylTxt.TabIndex = 6;
            // 
            // SzopTxt
            // 
            SzopTxt.Location = new Point(444, 98);
            SzopTxt.Name = "SzopTxt";
            SzopTxt.Size = new Size(100, 23);
            SzopTxt.TabIndex = 7;
            // 
            // CzasTxt
            // 
            CzasTxt.Location = new Point(444, 261);
            CzasTxt.Name = "CzasTxt";
            CzasTxt.Size = new Size(100, 23);
            CzasTxt.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 65);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Dydelfy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 65);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "Szopy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 147);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 11;
            label6.Text = "Krokodyle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 264);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "Czas";
            // 
            // Zapisz
            // 
            Zapisz.Location = new Point(116, 396);
            Zapisz.Name = "Zapisz";
            Zapisz.Size = new Size(75, 23);
            Zapisz.TabIndex = 13;
            Zapisz.Text = "Zapisz";
            Zapisz.UseVisualStyleBackColor = true;
            Zapisz.Click += Zapisz_Click;
            // 
            // Anuluj
            // 
            Anuluj.Location = new Point(277, 399);
            Anuluj.Name = "Anuluj";
            Anuluj.Size = new Size(75, 23);
            Anuluj.TabIndex = 14;
            Anuluj.Text = "Anuluj";
            Anuluj.UseVisualStyleBackColor = true;
            Anuluj.Click += button2_Click;
            // 
            // Ustawienia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Anuluj);
            Controls.Add(Zapisz);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CzasTxt);
            Controls.Add(SzopTxt);
            Controls.Add(krokodylTxt);
            Controls.Add(dydelfTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(yTxt);
            Controls.Add(xTxt);
            Name = "Ustawienia";
            Text = "Ustawienia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox xTxt;
        private TextBox yTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox dydelfTxt;
        private TextBox krokodylTxt;
        private TextBox SzopTxt;
        private TextBox CzasTxt;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button Zapisz;
        private Button Anuluj;
    }
}