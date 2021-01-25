using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        bool punto = false;
        bool operador = false;
        double resultado = 0;
        string ultimo_operador = "";
        int contador_operaciones = 0;
        bool ultima_pulsacion = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            
            punto = false;
            operador = false;
            resultado = 0;
            richTextBox1.Text = "0";
            contador_operaciones = 0;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "1";
                }
                else
                {
                    richTextBox1.Text += "1";
                }
            }
            else
            {
                richTextBox1.Text = "1";
                operador = false;
            }
            ultima_pulsacion = true;
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "2";
                }
                else
                {
                    richTextBox1.Text += "2";
                }
            }
            else
            {
                richTextBox1.Text = "2";
                operador = false;
            }
            ultima_pulsacion = true;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "3";
                }
                else
                {
                    richTextBox1.Text += "3";
                }
            }
            else
            {
                richTextBox1.Text = "3";
                operador = false;
            }
            ultima_pulsacion = true;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "4";
                }
                else
                {
                    richTextBox1.Text += "4";
                }
            }
            else
            {
                richTextBox1.Text = "4";
                operador = false;
            }
            ultima_pulsacion = true;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "5";
                }
                else
                {
                    richTextBox1.Text += "5";
                }
            }
            else
            {
                richTextBox1.Text = "5";
                operador = false;
            }
            ultima_pulsacion = true;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "6";
                }
                else
                {
                    richTextBox1.Text += "6";
                }
            }
            else
            {
                richTextBox1.Text = "6";
                operador = false;
            }
            ultima_pulsacion = true;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "7";
                }
                else
                {
                    richTextBox1.Text += "7";
                }
            }
            else
            {
                richTextBox1.Text = "7";
                operador = false;
            }
            ultima_pulsacion = true;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "8";
                }
                else
                {
                    richTextBox1.Text += "8";
                }
            }
            else
            {
                richTextBox1.Text = "8";
                operador = false;
            }
            ultima_pulsacion = true;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (operador == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "9";
                }
                else
                {
                    richTextBox1.Text += "9";
                }
            }
            else
            {
                richTextBox1.Text = "9";
                operador = false;
            }
            ultima_pulsacion = true;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }
            ultima_pulsacion = true;
        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            if (punto == false)
            {
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "0.";
                }
                else
                {
                    richTextBox1.Text += ",";
                }
            }
            punto = true;
        }

        
        private void button_suma_Click(object sender, EventArgs e)
        {
            if (ultima_pulsacion == true)
            {
                operador = true;
                contador_operaciones++;
                if (contador_operaciones == 1)
                {
                    resultado = Convert.ToDouble(richTextBox1.Text);
                }
                if (contador_operaciones > 1)
                {
                    if (ultimo_operador != "suma")
                    {
                        ultimo_resultado(ultimo_operador);
                    }
                    else
                    {
                        resultado += Convert.ToDouble(richTextBox1.Text);
                        richTextBox1.Text = Convert.ToString(resultado);
                    }
                }
            }
            ultimo_operador = "suma";
            punto = false;
            ultima_pulsacion = false;
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            if (ultima_pulsacion == true)
            {
                operador = true;
                contador_operaciones++;
                if (contador_operaciones == 1)
                {
                    resultado = Convert.ToDouble(richTextBox1.Text);
                }
                if (contador_operaciones > 1)
                {
                    if (ultimo_operador != "multi")
                    {
                        ultimo_resultado(ultimo_operador);
                    }
                    else
                    {
                        resultado = resultado * Convert.ToDouble(richTextBox1.Text);
                        richTextBox1.Text = Convert.ToString(resultado);
                    }
                }
            }
            ultimo_operador = "multi";
            punto = false;
            ultima_pulsacion = false;
        }


        private void ultimo_resultado(string ultimo)
        {
            switch (ultimo)
            {
                case "suma":
                 resultado+= Convert.ToDouble(richTextBox1.Text);
                 richTextBox1.Text = Convert.ToString(resultado);
                    break;
                case "resta":
                    resultado -= Convert.ToDouble(richTextBox1.Text);
                    richTextBox1.Text = Convert.ToString(resultado);
                    break;
                case "multi":
                    resultado =resultado * Convert.ToDouble(richTextBox1.Text);
                    richTextBox1.Text = Convert.ToString(resultado);
                    break;
                case "divi":
                    resultado =resultado / Convert.ToDouble(richTextBox1.Text);
                    richTextBox1.Text = Convert.ToString(resultado);
                    break;
                default:
                    resultado += Convert.ToDouble(richTextBox1.Text);
                    richTextBox1.Text = Convert.ToString(resultado);
                    break;
            }
        }
        private void button_resta_Click(object sender, EventArgs e)
        {
            if (ultima_pulsacion == true)
            {
                operador = true;
                contador_operaciones++;
                if (contador_operaciones == 1)
                {
                    resultado = Convert.ToDouble(richTextBox1.Text);
                }
                if (contador_operaciones > 1)
                {
                    if (ultimo_operador != "resta")
                    {
                        ultimo_resultado(ultimo_operador);
                    }
                    else
                    {
                        resultado -= Convert.ToDouble(richTextBox1.Text);
                        richTextBox1.Text = Convert.ToString(resultado);
                    }
                }
            }
            ultimo_operador = "resta";
            punto = false;
            ultima_pulsacion = false;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (ultima_pulsacion == true)
            {
                operador = true;
                contador_operaciones++;
                if (contador_operaciones == 1)
                {
                    resultado = Convert.ToDouble(richTextBox1.Text);
                }
                if (contador_operaciones > 1)
                {
                    if (ultimo_operador != "divi")
                    {
                        ultimo_resultado(ultimo_operador);
                    }
                    else
                    {
                        resultado = resultado / Convert.ToDouble(richTextBox1.Text);
                        richTextBox1.Text = Convert.ToString(resultado);
                    }
                }
            }
            ultimo_operador = "divi";
            punto = false;
            ultima_pulsacion = false;
        }

        private void button_igual_Click(object sender, EventArgs e)
        {
            if (ultima_pulsacion == true)
            {
                operador = true;
                ultimo_resultado(ultimo_operador);
            }
            contador_operaciones = 1;
            ultima_pulsacion = false;
        }
    }
}
