using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factura
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void fct_Click(object sender, EventArgs e)
        {
           double suma = float.Parse(p1.Text) + float.Parse(p2.Text) + float.Parse(p3.Text);

            sub.Text = suma.ToString();

            double iva = suma * .16;
            this.iva.Text = iva.ToString();

            double total = iva + suma;
            this.total.Text = total.ToString();
            
        }

        private void limpiar_Click(object sender, EventArgs e)
        {

            p1.Text = "";
            p2.Text = "";
            p3.Text = "";
            sub.Text = "";
            iva.Text = "";
            total.Text = "";
           
        }

    }
}
