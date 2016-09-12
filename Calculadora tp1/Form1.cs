using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_tp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void limpiar()
        {
            this.lblResultado.Text = "0";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperacion.Text = "";
 
        }
        private void operar()
        {
            Numero numero1 = new Numero(this.txtNumero1.Text);
            Numero numero2 = new Numero(this.txtNumero2.Text);
            double operar = Calculadora.operar(numero1, numero2, this.cmbOperacion.Text);
            this.lblResultado.Text = operar.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.limpiar();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.operar();
           
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
