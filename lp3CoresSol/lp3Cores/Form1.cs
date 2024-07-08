namespace lp3Cores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cor = "";

            cor = cmbCores.Text;
            if (cor == "Azul")
            {
                lblNome.ForeColor = Color.Blue;
            }
            cor = cmbCores.Text;
            if (cor == "Verde")
            {
                lblNome.ForeColor = Color.Green;
            }
            cor = cmbCores.Text;
            if (cor == "Amarelo")
            {
                lblNome.ForeColor = Color.Yellow;
            }
            cor = cmbCores.Text;
            if (cor == "Vermelho")
            {
                lblNome.ForeColor = Color.Red;
            }
            cor = cmbCores.Text;
            if (cor == "Laranja")
            {
                lblNome.ForeColor = Color.Orange;
            }

            //MessageBox.Show(cmbCores.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
