using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MáquinaDeComida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double produto = 21.5;
            double valor = double.Parse(TxtValor.Text);
            double conta = valor - produto;

            if (conta < 0)
            {
                MessageBox.Show("Voce não tem saldo suficiente");
            }
            else
            {
                MessageBox.Show("Produto comprado com sucesso!");
            }

        }

        private void BtnCompraA_Click(object sender, EventArgs e)
        {
            double produto3 = 15;
            double valor = double.Parse(TxtValor.Text);
            double conta = valor - produto3;

            if (conta < 0)
            {
                MessageBox.Show("Voce não tem saldo suficiente");
            }
            else
            {
                MessageBox.Show("Produto comprado com sucesso!");
            }
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btbcomparB_Click(object sender, EventArgs e)
        {
            double produto2 = 20;
            double valor = double.Parse(TxtValor.Text);
            double conta = valor - produto2;

            if (conta < 0)
            {
                MessageBox.Show("Voce não tem saldo suficiente");
            }
            else
            {
                MessageBox.Show("Produto comprado com sucesso!");
            }
        }

        private void BtnComparT_Click(object sender, EventArgs e)
        {
            double produto4 = 25;
            double valor = double.Parse(TxtValor.Text);
            double conta = valor - produto4;

            if (conta < 0)
            {
                MessageBox.Show("Voce não tem saldo suficiente");
            }
            else
            {
                MessageBox.Show("Produto comprado com sucesso!");
            }
        }
    }
}
