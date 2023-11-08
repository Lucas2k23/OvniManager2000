using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OvniManager2000
{
    public partial class Painel : Form
    {

        //objetos globais:
        BibliotecaOVNI.OVNI ovni;
        public Painel(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            this.ovni = ovni;
            AtualizarDados();

            //Popular o camboBox:
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        //metodo para atualizar os dados:
        public void AtualizarDados()
        {
            lblAbuzidos.Text = "Abduzidos: " + ovni.QtdAbduzidos;
            lblTripulantes.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblSituacao.Text = "Situação: " + (ovni.Situacao ? "ligado" : "Desligado");
            lblPlaneta.Text = " Planeta: " + ovni.PlanetaAtual;        }

        private void lblTripulantes_Click(object sender, EventArgs e)
        {

        }

        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void btnTripulante_Click(object sender, EventArgs e)
        {

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar() == false)
            {
                MessageBox.Show("A nave ja esta ligada!");
            }
            AtualizarDados();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar() == false)
            {
                MessageBox.Show("A nave ja esta Desligada!");
            }
            AtualizarDados();
        }
    }
}
