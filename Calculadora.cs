using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora___LUIS_MONTERO
{
    public partial class Form_Calculadora : Form
    {
        //Atributos
        double primero, segundo;
        string operador;

        public Form_Calculadora()
        {
            InitializeComponent();
        }

        Clases.C_Funciones funciones = new Clases.C_Funciones();//Objeto

        private void btn_cero_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "0";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + ".";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "3";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "6";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "5";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "4";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "9";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "8";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            edit_pantalla.Text = edit_pantalla.Text + "7";
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(edit_pantalla.Text);
            edit_pantalla.Clear();
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(edit_pantalla.Text);
            edit_pantalla.Clear();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(edit_pantalla.Text);
            edit_pantalla.Clear();
        }

        

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(edit_pantalla.Text);
            edit_pantalla.Clear();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            edit_pantalla.Clear();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(edit_pantalla.Text);

            double Sum, Res, Mul, Div;

            switch (operador)
            {
                case "+":
                    Sum = funciones.Sumar(primero, segundo);
                    edit_pantalla.Text = Sum.ToString();
                    break;

                case "-":
                    Res = funciones.Restar(primero, segundo);
                    edit_pantalla.Text = Res.ToString();
                    break;

                case "*":
                    Mul = funciones.Multiplicar(primero, segundo);
                    edit_pantalla.Text = Mul.ToString();
                    break;

                case "/":
                    Div = funciones.Dividir(primero, segundo);
                    edit_pantalla.Text = Div.ToString();
                    break;
            }

        }
        
    }
}
