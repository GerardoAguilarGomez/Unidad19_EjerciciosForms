using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sistema_operativo = "";
            if (this.radioButton1.Checked)
            {
                sistema_operativo = radioButton1.Text;
            }else if (this.radioButton2.Checked)
            {
                sistema_operativo = radioButton2.Text;
            }
            else
            {
                sistema_operativo = radioButton3.Text;
            }

            string conocimientos = "";
            if (this.checkBox1.Checked)
            {
                conocimientos += checkBox1.Text + ", ";
            }
            if (this.checkBox2.Checked)
            {
                conocimientos += checkBox2.Text + ", ";
            }
            if (this.checkBox3.Checked)
                {
                conocimientos += checkBox3.Text + ", ";
            }

            MessageBox.Show("Sistema operativo: " + sistema_operativo + ". Especialidad/es: " + conocimientos + ". Horas dedicadas: " + this.trackBar1.Value);
        }
    }
}
