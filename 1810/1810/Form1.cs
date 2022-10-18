using System.Security.Cryptography.X509Certificates;

namespace _1810
{
    public partial class Form1 : Form
    {
        Form2 form2;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Owner = this;
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void programdanÇýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Programdan çýkmak istediðinize emin misiniz ?" , "UYARI!",
                MessageBoxButtons.YesNo , MessageBoxIcon.Question
                );
            if (x == DialogResult.Yes)

            Application.Exit();
        }

        private void öðrenciKimlikBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}