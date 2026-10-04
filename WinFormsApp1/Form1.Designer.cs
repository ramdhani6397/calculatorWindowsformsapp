namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNilaiA = new TextBox();
            txtNilaiB = new TextBox();
            btnHitung = new Button();
            groupBox1 = new GroupBox();
            lstHasil = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
             
            // label1
             
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Nilai A";
             
            // label2
            
            label2.AutoSize = true;
            label2.Location = new Point(20, 58);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Nilai B";
             
            // txtNilaiA
             
            txtNilaiA.Location = new Point(90, 20);
            txtNilaiA.Name = "txtNilaiA";
            txtNilaiA.Size = new Size(120, 27);
            txtNilaiA.TabIndex = 2;
             
            // txtNilaiB
             
            txtNilaiB.Location = new Point(90, 55);
            txtNilaiB.Name = "txtNilaiB";
            txtNilaiB.Size = new Size(120, 27);
            txtNilaiB.TabIndex = 3;
             
            // btnHitung
             
            btnHitung.Location = new Point(90, 92);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(120, 30);
            btnHitung.TabIndex = 4;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
             
            // groupBox1
             
            groupBox1.Controls.Add(lstHasil);
            groupBox1.Location = new Point(15, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 200);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "[ Hasil ]";
             
            // lstHasil
             
            lstHasil.FormattingEnabled = true;
            lstHasil.Location = new Point(10, 26);
            lstHasil.Name = "lstHasil";
            lstHasil.Size = new Size(330, 164);
            lstHasil.TabIndex = 0;
             
            // Form1
             
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 351);
            Controls.Add(groupBox1);
            Controls.Add(btnHitung);
            Controls.Add(txtNilaiB);
            Controls.Add(txtNilaiA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Aplikasi Calculator Versi Windows";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNilaiA;
        private TextBox txtNilaiB;
        private Button btnHitung;
        private GroupBox groupBox1;
        private ListBox lstHasil;
    }
}