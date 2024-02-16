using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_CERTA
{
    public partial class Form1 : Form
    {
        string operador;
        double a = 0;
        bool validar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void text_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            text_valor.Text = text_valor.Text + bt.Text;
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToDouble(text_valor.Text);
                label1.Text = Convert.ToString(a) + "+";
                text_valor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = text_valor.Text + btn_soma.Text;
                a = Convert.ToDouble(text_valor.Text);
                text_valor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToDouble(text_valor.Text);
                label1.Text = Convert.ToString(a) + "/";
                text_valor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = text_valor.Text + btn_div.Text;
                a = Convert.ToDouble(text_valor.Text);
                text_valor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToDouble(text_valor.Text);
                label1.Text = Convert.ToString(a) + "*";
                text_valor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = text_valor.Text + btn_mult.Text;
                a = Convert.ToDouble(text_valor.Text);
                text_valor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btn_subs_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToDouble(text_valor.Text);
                label1.Text = Convert.ToString(a) + "-";
                text_valor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = text_valor.Text + btn_subs.Text;
                a = Convert.ToDouble(text_valor.Text);
                text_valor.Text = "";
                operador = "-";
                validar = true;
            }
        } 
        private void btn_clear_Click(object sender, EventArgs e)
        {
            text_valor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + text_valor.Text + "=";
                text_valor.Text = Convert.ToString(a + Convert.ToSingle(text_valor.Text));
            }
            else if (operador == "-")
            {
                label1.Text = label1.Text + text_valor.Text + "=";
                text_valor.Text = Convert.ToString(a - Convert.ToSingle(text_valor.Text));
            }
            else if (operador == "*")
            {
                label1.Text = label1.Text + text_valor.Text + "=";
                text_valor.Text = Convert.ToString(a * Convert.ToSingle(text_valor.Text));
            }
            else if (operador == "/")
            {
                label1.Text = label1.Text + text_valor.Text + "=";
                text_valor.Text = Convert.ToString(a / Convert.ToSingle(text_valor.Text));
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(text_valor.Text);
                label1.Text = Convert.ToString(a) + "-";
                text_valor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = text_valor.Text + btn_subs.Text;
                a = Convert.ToInt32(text_valor.Text);
                text_valor.Text = "";
                operador = "-";
                validar = true;
            }

        }
    }
}
    
    

