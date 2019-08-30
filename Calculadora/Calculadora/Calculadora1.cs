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
    public partial class Calculadora1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora1()
        {
            InitializeComponent();
        }

        Clases.ClaseSuma obj = new Clases.ClaseSuma();
        Clases.ClaseResta obj2 = new Clases.ClaseResta();
        Clases.ClaseMultiplicacion obj3 = new Clases.ClaseMultiplicacion();
        Clases.ClaseDivision obj4 = new Clases.ClaseDivision();
        Clases.ClasePorcentaje obj5 = new Clases.ClasePorcentaje();
        private void B0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Porcentaje_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);
            double Sum;
            double Res;
            double Div;
            double Mul;
            double Por;

            switch(operador)
            {
                case "+": Sum = obj.Sumar((primero), (segundo));
                    pantalla.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Resta((primero), (segundo));
                    pantalla.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicacion((primero), (segundo));
                    pantalla.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Division((primero), (segundo));
                    pantalla.Text = Div.ToString();
                    break;
                case "%":
                    Por = obj5.Porcentaje((primero), (segundo));
                    pantalla.Text = Por.ToString();
                    break;
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length == 1)
                pantalla.Text = "";
            else
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
        }
    }
}
