namespace Pets
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = rdbMacho.Checked ? "Macho" : rdbFemea.Checked ? "Fêmea" : "Indefinido";
           
            MessageBox.Show("Nome: "+txbNome.Text +
                        "\nIdade: "+txbIdade.Text +
                        "\nEspécie: " +cmbEspecie.Text +
                        "\nSexo: "+ sexo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbIdade.Text = "";
            txbNome.Text = "";
            cmbEspecie.SelectedIndex = 0;
            rdbFemea.Checked = false;
            rdbMacho.Checked = false;   
        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
