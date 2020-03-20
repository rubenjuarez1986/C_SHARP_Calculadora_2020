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
        //aqui declaro las variables instancia

        //operando1 guardará el primer numero
        double operando1 = 0;
        //en el string operación guardo la operación que ha sido pulsada
        String operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else
            {
                label1.Text = label1.Text + boton.Text;
            }
         }

        private void button11_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }


        private void button10_Click(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if (operacion == "/")
            {
                resultado = operando1 / operando2;
            }
           

            label1.Text = Convert.ToString(resultado);
        }

        private void button17_Click(object sender, EventArgs e) //x^
        {
            operando1 = Convert.ToDouble(label1.Text);
            operando1 *= operando1;
            label1.Text = Convert.ToString(operando1);
        }

        private void button16_Click(object sender, EventArgs e)//pi
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = "3,14";
            }
            else
            {
                operacion = boton.Text;
                operando1 = Convert.ToDouble(label1.Text);
                operando1 *= Math.PI;
                label1.Text = Convert.ToString(operando1);
            }
        }

       
    }
}