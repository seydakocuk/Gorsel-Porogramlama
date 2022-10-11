namespace vizefinalhesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;

            try
            {

                vize = Convert.ToDouble(numericUpDown1.Value);
                final = Convert.ToDouble(numericUpDown2.Value);




                ortalama = vize * 0.4 + final * 0.6;



                label5.Text = ortalama.ToString();


                if (final <= 49)
                {
                    label5.Text = "ORTALAMANIZ:" + ortalama + "Harf Notunuz : FF";
                    label5.ForeColor = Color.Red;
                    MessageBox.Show("Final notunuz 50' den küçük olduðu için kaldýnýz !");
                }


                else if (ortalama > 0 && ortalama <= 34)
                {
                    label5.Text = "ORTALAMANIZ:" + ortalama + " Harf Notunuz : FF";
                    label5.ForeColor = Color.Red;

                }
                else if (ortalama >= 35 && ortalama <= 44)
                {
                    label5.Text = "ORTALAMANIZ:" + ortalama + "Harf Notunuz : DD";
                    label5.ForeColor = Color.Red;
                }
                else if (ortalama >= 45 && ortalama <= 49)
                {
                    label5.Text = "ORTALAMANIZ:" + ortalama + "Harf Notunuz : DC";
                    label5.ForeColor = Color.Red;
                }
                else if (ortalama >= 50 && ortalama <= 54)
                {
                    label5.Text = "ORTALAMANIZ:" + ortalama + "Harf Notunuz : CC";
                    label5.ForeColor = Color.Green;
                }
                else if (ortalama >= 55 && ortalama <= 64)
                {
                    label5.Text = "ORTALAMANIZ:" + ortalama + "Harf Notunuz : CB";
                    label5.ForeColor = Color.Green;
                }
                else if (ortalama >= 65 && ortalama <= 69)
                {
                    label5.Text = "ORTALAMANIZ:" + ortalama + "Harf Notunuz : BB";
                    label5.ForeColor = Color.Green;
                }
                else if (ortalama >= 70 && ortalama <= 79)
                {
                    label5.Text = "ORTALAMANIZ:" + ortalama + "Harf Notunuz : BA";
                    label5.ForeColor = Color.Green;
                }
                else if (ortalama >= 80 && ortalama >= 100)
                {
                    label5.Text = "ORTALAMANIZ:" + ortalama + "Harf Notunuz : AA";
                    label5.ForeColor = Color.Green;
                }



            }
            catch (Exception ex)
            {
                throw;
            }
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label5.Text = "";
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}