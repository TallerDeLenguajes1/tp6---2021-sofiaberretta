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
            KeyPreview = true;
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = " ";
            contieneOp = false;
            contienePunto = false;
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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    boton1.PerformClick();
                    break;
                case '2':
                    boton2.PerformClick();
                    break;
                case '3':
                    boton3.PerformClick();
                    break;
                case '4':
                    boton4.PerformClick();
                    break;
                case '5':
                    boton5.PerformClick();
                    break;
                case '6':
                    boton6.PerformClick();
                    break;
                case '7':
                    boton7.PerformClick();
                    break;
                case '8':
                    boton8.PerformClick();
                    break;
                case '9':
                    boton9.PerformClick();
                    break;
                case '0':
                    boton0.PerformClick();
                    break;
                case '+':
                    suma.PerformClick();
                    break;
                case '-':
                    resta.PerformClick();
                    break;
                case '/':
                    division.PerformClick();
                    break;
                case '*':
                    multiplicacion.PerformClick();
                    break;
                case '.':
                    punto.PerformClick();
                    break;
                default:
                    break;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                igual.PerformClick();
            } else if(e.KeyChar == Convert.ToChar(Keys.Delete))
            {
                limpiar.PerformClick();
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            calcularResultado();
        }

        public void calcularResultado()
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

        }
    }
}
