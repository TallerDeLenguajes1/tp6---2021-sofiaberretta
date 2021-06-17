using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        bool contieneOp = false, contienePunto = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = " ";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "9";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            if(txtCalculo.Text != "" && !contieneOp)
            {
                txtCalculo.Text += "+";
                contieneOp = true;
                contienePunto = false;
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "6";
        }

        private void resta_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text != "" && !contieneOp)
            {
                txtCalculo.Text += "-";
                contieneOp = true;
                contienePunto = false;
            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "3";
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text != "" && !contieneOp)
            {
                txtCalculo.Text += "*";
                contieneOp = true;
                contienePunto = false;
            }
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            txtCalculo.Text += "0";
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text != "" && !contieneOp)
            {
                txtCalculo.Text += "/";
                contieneOp = true;
                contienePunto = false;
            }
        }

        private void punto_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text != "" && !contienePunto)
            {
                txtCalculo.Text += ",";
                contienePunto = true;
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            string calculoFinal = txtCalculo.Text;
            Calculadora Resultado = new Calculadora();

            if (txtCalculo.Text.Contains('+'))
            {
                string[] arregloTexto = calculoFinal.Split('+');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                txtCalculo.Text = Resultado.Suma().ToString();
            }
            else if (txtCalculo.Text.Contains('-'))
            {
                string[] arregloTexto = calculoFinal.Split('-');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                txtCalculo.Text = Resultado.Resta().ToString();
            }
            else if (txtCalculo.Text.Contains('*'))
            {
                string[] arregloTexto = calculoFinal.Split('*');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                txtCalculo.Text = Resultado.Multiplicacion().ToString();
            }
            else if (txtCalculo.Text.Contains('/'))
            {
                string[] arregloTexto = calculoFinal.Split('/');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                txtCalculo.Text = Resultado.Division().ToString();
            }

            Resultado = new Calculadora();
        }
    }
}
