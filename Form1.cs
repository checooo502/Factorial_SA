using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_SA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblresultado.Text = "";
            if (int.TryParse(txtnumero.Text, out int num))
            {
                long factorial = 1;
                string multiplicacion = "";
                for (int i = num; i > 0; i--)
                {
                    factorial = factorial * i;
                    listBox1.Items.Add(i);

                    multiplicacion += (i == 1) ? $"{i}" : $"{i}";
                }
                lblresultado.Text = $"{num}! = {multiplicacion} = {factorial}";
            }
           else
            {
                MessageBox.Show("ingrese un numero valido");
            }
        }
    }
}
