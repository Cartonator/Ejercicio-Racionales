using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racionales.Racional;

namespace Racionales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);


            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional producto = r1.Multiplicar(r2);

            textBox5.Text = producto.getA().ToString();
        }
    }
}
