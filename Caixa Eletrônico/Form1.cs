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
            double Valor = (double)numOperSaldo.Value;
            double Dep = (double)numOperval.Value;
            double Limit = (double)numOperlim.Value;
            Soma = Valor + Dep;
            numOperSaldo.Value = (decimal)Soma;
            erro.Text = " ";


        }

        private void btSac_Click(object sender, EventArgs e)

        {
            double Sub = 0;
            double Valor = (double)numOperSaldo.Value;
            double Sac = (double)numOperval.Value;
            if (Valor - Sac >= -(double)numOperlim.Value)
            {
                Sub = Valor - Sac;
                numOperSaldo.Value = (decimal)Sub;
                erro.Text = " ";
            }

            else
            {
                erro.Text = "Saldo insuficiente";
            }






        }

        private void numOperlim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSal_Click(object sender, EventArgs e)
        {

        }

        private void numOperSaldo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void erro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaxa.Text =
                $"* Taxa: {taxa * 100}% a.c {tmrJuros.Interval / 1000}s";
        }
        double taxa = 0.05;
        private void timer1_Tick(object sender, EventArgs e)
        {
            double Valor = (double)numOperSaldo.Value;
            double juros = Valor * 1 * taxa;
            double saldo = juros + Valor;
            numOperSaldo.Value = (decimal)saldo;
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Deseja mesmo sair do banco?",
                "Banco moleque Ney",
                MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                MessageBox.Show("Genio da bola");
            }
            else
            {
                MessageBox.Show("PALMEIRAS 4 FORÇA DE SP, CHORA PORCO");
            }
        }
    }
}
