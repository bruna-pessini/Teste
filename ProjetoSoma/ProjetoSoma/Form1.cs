using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjetoSoma.Modelo;

namespace ProjetoSoma
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }
        
        private void btnsomar_Click(object sender, EventArgs e)
            //pega o primeiro e joga para o atributo
        controle controle = new controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text, "+");
        lblResultado.Text = Controler.Resposta;
        {
           
            Controler controler = new Controler();
          lblresultado.Text = controler.Calcular(txbprimeironumero.Text, txbsegundonumero.Text, "+");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
           
        }

        private void txbprimeironumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }
    }
    
}   
