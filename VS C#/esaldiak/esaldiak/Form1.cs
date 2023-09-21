namespace esaldiak
{
    public partial class Form1 : Form
    {
        Esaldia es = new Esaldia();
        public Form1()
        {
            InitializeComponent();
            esaldia1.Enabled = true;
            esaldia2.Enabled = false;
            esaldia3.Enabled = false;
            esaldia4.Enabled = false;
            esaldia5.Enabled = false;

        }

        private void esaldia1_Click(object sender, EventArgs e)
        {
            es.Testua = Rtxt.Text;
            es.Esaldiabatu();

            esaldia1.Enabled = false;
            esaldia2.Enabled = true;

            Rtxt.Text = string.Empty;
        }

        private void esaldia2_Click(object sender, EventArgs e)
        {

            es.Testua = Rtxt.Text;
            es.Esaldiabatu();
            esaldia2.Enabled = false;
            esaldia3.Enabled = true;
            Rtxt.Text = string.Empty;


        }

        private void esaldia3_Click(object sender, EventArgs e)
        {
            es.Testua = Rtxt.Text;
            es.Esaldiabatu();

            esaldia4.Enabled = true;
            esaldia3.Enabled = false;
            Rtxt.Text = string.Empty;

        }

        private void esaldia4_Click(object sender, EventArgs e)
        {
            es.Testua=Rtxt.Text;
            es.Esaldiabatu();
            esaldia5.Enabled = true;
            esaldia4.Enabled = false;
            Rtxt.Text = string.Empty;


        }

        private void esaldia5_Click(object sender, EventArgs e)
        {
            es.Testua = Rtxt.Text;
            es.Esaldiabatu();

            esaldia5.Enabled = false;


            Rtxt.Text = string.Empty;


        }

        private void lotu_Click(object sender, EventArgs e)

        {

            MessageBox.Show(es.Esaldialotuta);

        }

        private void reset_Click(object sender, EventArgs e)
        {
            Rtxt.Clear();
        }

        private void itxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}