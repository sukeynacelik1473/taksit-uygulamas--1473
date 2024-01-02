using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASİT_UYGULAMASI_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double taksit = Convert.ToInt32(txtFıyat.Text) / Convert.ToDouble(numericUpDown1.Value);

            DateTime tarih = DateTime.Now;
            lbTaksıt.Items.Clear();
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                lbTaksıt.Items.Add($" {i} taksit: {taksit} ");

                DateTime yeniTarih = DateTime.Now;

                lbTarih.Items.Add($"Yıl: {yeniTarih.Year} Ay: {yeniTarih.Month}. Gün: {yeniTarih.Day} ");

            }
        }
    }
}   
