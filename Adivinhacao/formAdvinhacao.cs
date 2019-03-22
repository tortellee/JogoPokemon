using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivinhacao
{
    public partial class formAdvinhacao : Form
    {
        public formAdvinhacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random dado = new Random();
            int valor;
            valor = dado.Next(1, 4);

            if(valor ==1)
            {
                Meow.Visible = true;
                Snorlax.Visible = false;
                Pica.Visible = false;

            }
            if (valor == 2)
            {
                Meow.Visible = false;
                Snorlax.Visible = true;
                Pica.Visible = false;

            }
            if (valor == 3)
            {
                Meow.Visible = false;
                Snorlax.Visible = false;
                Pica.Visible = true;

            }
            //se o valor do dado for 1 entao voce acertou
            if (valor == 1)
            {
                MessageBox.Show("Você ACERTOU", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Você ERROU", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void formAdvinhacao_Load(object sender, EventArgs e)
            //para nao mover a borda com o mouse
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
            //dado aleatorio
        {
            Random dado = new Random();
            int valor;
            valor = dado.Next(1, 4);
            //se o valor do dado for 1 entao Meow aparece
            if (valor == 1)
            {
                Meow.Visible = true;
                Snorlax.Visible = false;
                Pica.Visible = false;
            }

            //se o valor do dado for 2 entao Snorlax aparece
            if (valor == 2)
            {
                Meow.Visible = false;
                Snorlax.Visible = true;
                Pica.Visible = false;
            }
            //se o valor do dado for 3 entao Picachu aparece
            if (valor == 3)
            {
                Meow.Visible = false;
                Snorlax.Visible = false;
                Pica.Visible = true;

            }
            //se o valor do dado for 3 entao voce acertou
            if (valor == 3)
            {
                MessageBox.Show("Você ACERTOU", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Você ERROU", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random dado = new Random();
            int valor;
            valor = dado.Next(1, 4);

            if (valor == 1)
            {
                Meow.Visible = true;
                Snorlax.Visible = false;
                Pica.Visible = false;

            }
            if (valor == 2)
            {
                Meow.Visible = false;
                Snorlax.Visible = true;
                Pica.Visible = false;

            }
            if (valor == 3)
            {
                Meow.Visible = false;
                Snorlax.Visible = false;
                Pica.Visible = true;

            }
            //se o valor do dado for 2 entao voce acertou
            if (valor == 2)
            {
                MessageBox.Show("Você ACERTOU", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Você ERROU", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
