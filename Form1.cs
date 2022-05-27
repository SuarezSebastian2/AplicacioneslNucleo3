using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacioneslNucleo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            double dt1, dt2, dtR;
            dt1 = double.Parse(num1.Text);
            dt2 = double.Parse(num2.Text);
            dtR = dt1 + dt2;
            result.Text = dtR.ToString();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            result.Text = "";
        }
    }
}
