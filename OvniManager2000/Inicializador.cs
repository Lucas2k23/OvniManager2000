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
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
        }

        private void Inicializador_Activated(object sender, EventArgs e)
        {
           
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            int maxAbduzidos = int.Parse(NudAbduzidos.Text);
            int maxTripulantes = int.Parse(NudTripulantes.Text);
            string planetaOrigem = CmbPlaneta.Text;

            //Instanciar o ovmi:
            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxAbduzidos, maxTripulantes,planetaOrigem);

            //instanciar a janela do painel:
            Painel janela = new Painel(ovni);

            //Abrir a janela 
            janela.ShowDialog();
        }


        private void Inicializador_Load(object sender, EventArgs e)
        {
            CmbPlaneta.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }
    }
}
