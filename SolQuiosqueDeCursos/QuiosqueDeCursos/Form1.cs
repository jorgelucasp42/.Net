using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuiosqueDeCursos
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> cursosPrecos = new Dictionary<string, decimal>()
        {
            {"Aprendendo Orientação a Objetos", 25850M},
            {"Banco de Dados: Teoria e Prática", 26000M},
            {"Orientação a Objetos com C#", 21545M},
            {"HTML / CSS / JavaScript", 28050M}
        };


        private List<string> cursosSelecionados = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarListaCursosSelecionados();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTotalAPagar();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void AtualizarListaCursosSelecionados()
        {
           
            AtualizarTotalAPagar(); 
        }
        private void AtualizarTotalAPagar()
        {
            decimal total = 0;
           

            
            decimal descontoCurso = checkBox1.Checked ? 0.10M : 0; // Substitua pela lógica correta de verificação do curso
            decimal descontoPagamento = cmbCursos.SelectedItem != null && (cmbCursos.SelectedItem.ToString() == "Pix" || cmbCursos.SelectedItem.ToString() == "Dinheiro") ? 0.03M : 0;
            decimal descontoTotal = 1 - (descontoCurso + descontoPagamento - descontoCurso * descontoPagamento);
            total *= descontoTotal;

            // Atualizar o label com o total a pagar
            lblValor.Text = $"Total a Pagar: {total.ToString("C")}";
        }


    }
}
