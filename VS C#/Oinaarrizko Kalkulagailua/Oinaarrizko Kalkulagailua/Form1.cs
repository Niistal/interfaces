namespace Oinaarrizko_Kalkulagailua
{
    public partial class Form1 : Form
    {
        kalkulagailua k=new kalkulagailua();
        public Form1()
        {
            InitializeComponent();
        }

        private void gehi_Click(object sender, EventArgs e)
        {
            try {
                balidatu();
                MessageBox.Show(k.Gehiketa().ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("ez duzu formatu zuzena idatzi");
            }
           
        }

        private void ken_Click(object sender, EventArgs e)
        {
            kalkulagailua k = new kalkulagailua(float.Parse(txt1.Text), float.Parse(txt2.Text));
            MessageBox.Show(k.Kenketa().ToString());
        }

        private void bider_Click(object sender, EventArgs e)
        {
            kalkulagailua kalkulagailua = new kalkulagailua(float.Parse(txt1.Text), float.Parse(txt2.Text));
            MessageBox.Show(kalkulagailua.Biderketa().ToString());
        }

        private void zati_Click(object sender, EventArgs e)
        {
            kalkulagailua kalkulagailua = new kalkulagailua(float.Parse(txt1.Text), float.Parse(txt2.Text));
            MessageBox.Show(kalkulagailua.Zatiketa().ToString());
        }
        private void balidatu()
        {
          k.Zenbaki1= float.Parse(txt1.Text);
          k.Zenbaki2= float.Parse(txt2.Text);
        }
    }
}