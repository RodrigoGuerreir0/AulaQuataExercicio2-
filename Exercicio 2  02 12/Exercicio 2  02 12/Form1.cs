using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_2__02_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mensagem1.Visible= false;
           
        }

        private void mensagem1_Click(object sender, EventArgs e)
        {
            
        }

      

        private void botao2_Click(object sender, EventArgs e)
        {
            mensagem1.Visible = true;
            mensagem1.Text = "Abóbora";
            
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            mensagem1.Visible = true;
            mensagem1.Text = "Pimentão";
        }
    }
}
