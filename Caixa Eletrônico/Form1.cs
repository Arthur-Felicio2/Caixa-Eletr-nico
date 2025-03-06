using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletrônico
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numOperval_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btDep_Click(object sender, EventArgs e)
        {
            double Soma = 0;
            double Valor = (double)numOperlim.Value;
            double Dep = (double)numOperval.Value;
            Soma = Valor + Dep;
            numOperSaldo.Value = (decimal)Soma;
        }

        private void btSac_Click(object sender, EventArgs e)
        {
           
            

        }

        private void numOperlim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSal_Click(object sender, EventArgs e)
        {
          
        }

        private void numOperSaldo_ValueChanged(object sender, EventArgs e)
        {
            numOperlim.Value = numOperSaldo.Value;
        }
    }
}
