using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjamplosdeControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAcuadrado_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
          decimal resultado =  a.Cuadrado(numLado.Value);
            lblCuadrado.Text = resultado + "";
        }

        private void buttonATriangulo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Triangulo(numBase.Value,numAltura.Value);
            lblTriangulo.Text = resultado + "";
        }

        private void numDate1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonARectangulo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Rectangulo(numBase1.Value, numAltura1.Value);
            lblRectangulo.Text = resultado + "";
        }

        private void buttonAParalelogramo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Paralelogramo(numBase2.Value, numAltura2.Value);
            lblParalelogramo.Text = resultado + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonARombo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Rombo(numDiagonalM.Value, numDiagonalm2.Value);
            lblRombo.Text = resultado + "";
        }

        private void buttonARomboide_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Romboide(numBase3.Value, numAltura3.Value);
            lblRomboide.Text = resultado + "";
        }

        private void buttonATrapecio_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Trapecio(numAltura4.Value, numBaseM.Value, numBasem2.Value);
            lblTrapecio.Text = resultado + "";
        }

        private void buttonACirculo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Circulo(numPI.Value, numRadio.Value);
            lblCirculo.Text = resultado + "";
        }

        private void buttoAPoligonoregular_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Poligono(numPerimetro.Value, numDate16.Value);
            lblPoligonoR.Text = resultado + "";
        }
    }
}
