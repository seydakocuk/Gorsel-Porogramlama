using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _1910
    
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();
            this.Hide();
        }
        public void kitapEkle(string kitapAdi)
        {
            listBox1.Items.Add(kitapAdi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int siraNo = listBox1.SelectedIndex; //seçili elemanın sıra numarasını verir

            if (siraNo > -1)
            {
                MessageBox.Show("Silmek istediğinize emin misiniz ?" , "UYARI" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                listBox1.Items.RemoveAt(siraNo);
            }
            else
            {
                MessageBox.Show("Önce silinecek elemanı seçmelisiniz " , "HATA" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Değiştirmek için herhangi bir isim seç");
            }
            else
            {
               
                
            }
            
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
