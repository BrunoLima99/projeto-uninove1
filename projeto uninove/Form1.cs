using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_uninove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBoasVindasaolavarapido_Click(object sender, EventArgs e)

        {

            lbResultado.Text = "olá " + txtNome.Text + " " + txtSobrenome.Text + ",seja bem-vindo(a) ao lava rápido!";
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void ibResultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
