using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto138controlesDado
{
    public partial class Dado : UserControl
    {
        private int valor = 1;
        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                if (value>=1 && value<=6)
                {
                    valor = value;
                    Invalidate();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un valor entre 1 y 6");
                }
            }
        }

        public Dado()
        {
            InitializeComponent();
            Width = 100;
            Height = 100;
        }

        private void Dado_Paint(object sender, PaintEventArgs e)
        {
            Graphics lienzo = CreateGraphics();
            lienzo.DrawRectangle(new Pen(Color.Black), 0, 0, Width-1, Height-1);
            int diametro = Width / 5;
            if (Valor==1 || Valor== 3 || Valor == 5)
            {
                lienzo.FillEllipse(new SolidBrush(Color.Red), (Width*0.5f)-(diametro/2), (Height*0.5f) - (diametro / 2), diametro, diametro);
            }
            if (Valor == 2 || Valor == 3 || Valor == 4 || Valor == 5 || Valor == 6)
            {
                lienzo.FillEllipse(new SolidBrush(Color.Red), (Width * 0.25f) - (diametro / 2), (Height * 0.25f) - (diametro / 2), diametro, diametro);
                lienzo.FillEllipse(new SolidBrush(Color.Red), (Width * 0.75f) - (diametro / 2), (Height * 0.75f) - (diametro / 2), diametro, diametro);
            }
            if (Valor == 4 || Valor == 5 || Valor == 6)
            {
                lienzo.FillEllipse(new SolidBrush(Color.Red), (Width * 0.75f) - (diametro / 2), (Height * 0.25f) - (diametro / 2), diametro, diametro);
                lienzo.FillEllipse(new SolidBrush(Color.Red), (Width * 0.25f) - (diametro / 2), (Height * 0.75f) - (diametro / 2), diametro, diametro);
            }
            if (Valor == 6)
            {
                lienzo.FillEllipse(new SolidBrush(Color.Red), (Width * 0.25f) - (diametro / 2), (Height * 0.5f) - (diametro / 2), diametro, diametro);
                lienzo.FillEllipse(new SolidBrush(Color.Red), (Width * 0.75f) - (diametro / 2), (Height * 0.5f) - (diametro / 2), diametro, diametro);
            }

        }

        private void Dado_Resize(object sender, EventArgs e)
        {
            Width = Height; //para lograr que el dado siempre sea un cuadrado
        }
    }
}
