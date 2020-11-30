using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto138controlesDado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            dado1.Valor = aleatorio.Next(1, 7);
            dado2.Valor = aleatorio.Next(1, 7);
            dado3.Valor = aleatorio.Next(1, 7);
            if (dado1.Valor == dado2.Valor && dado1.Valor == dado3.Valor)
                MessageBox.Show("Ganó");
            else
                MessageBox.Show("Perdió");
        }
    }
}
