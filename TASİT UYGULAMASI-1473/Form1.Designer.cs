namespace TASİT_UYGULAMASI_1473
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtFıyat = new System.Windows.Forms.TextBox();
            this.lbTaksıt = new System.Windows.Forms.ListBox();
            this.lbTarih = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(28, 137);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(168, 60);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtFıyat
            // 
            this.txtFıyat.Location = new System.Drawing.Point(28, 52);
            this.txtFıyat.Name = "txtFıyat";
            this.txtFıyat.Size = new System.Drawing.Size(168, 20);
            this.txtFıyat.TabIndex = 1;
            this.txtFıyat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbTaksıt
            // 
            this.lbTaksıt.FormattingEnabled = true;
            this.lbTaksıt.Location = new System.Drawing.Point(234, 65);
            this.lbTaksıt.Name = "lbTaksıt";
            this.lbTaksıt.Size = new System.Drawing.Size(120, 212);
            this.lbTaksıt.TabIndex = 2;
            // 
            // lbTarih
            // 
            this.lbTarih.FormattingEnabled = true;
            this.lbTarih.Location = new System.Drawing.Point(409, 65);
            this.lbTarih.Name = "lbTarih";
            this.lbTarih.Size = new System.Drawing.Size(120, 212);
            this.lbTarih.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(28, 90);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(168, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbTarih);
            this.Controls.Add(this.lbTaksıt);
            this.Controls.Add(this.txtFıyat);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtFıyat;
        private System.Windows.Forms.ListBox lbTaksıt;
        private System.Windows.Forms.ListBox lbTarih;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

