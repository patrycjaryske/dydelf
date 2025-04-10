namespace dydelf
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
            label1 = new Label();
            start = new Button();
            ustawienia = new Button();
            koniec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 68);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Gdzie jest dydelf?";
            // 
            // start
            // 
            start.Location = new Point(328, 108);
            start.Name = "start";
            start.Size = new Size(75, 23);
            start.TabIndex = 1;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // ustawienia
            // 
            ustawienia.Location = new Point(328, 157);
            ustawienia.Name = "ustawienia";
            ustawienia.Size = new Size(75, 23);
            ustawienia.TabIndex = 2;
            ustawienia.Text = "Ustawienia";
            ustawienia.UseVisualStyleBackColor = true;
            ustawienia.Click += ustawienia_Click;
            // 
            // koniec
            // 
            koniec.Location = new Point(328, 208);
            koniec.Name = "koniec";
            koniec.Size = new Size(75, 23);
            koniec.TabIndex = 3;
            koniec.Text = "Koniec";
            koniec.UseVisualStyleBackColor = true;
            koniec.Click += koniec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(koniec);
            Controls.Add(ustawienia);
            Controls.Add(start);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button start;
        private Button ustawienia;
        private Button koniec;
    }
}
