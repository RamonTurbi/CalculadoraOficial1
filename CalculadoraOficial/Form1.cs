using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraOficial.Clases;


namespace CalculadoraOficial
{
    public partial class Form1 : Form 
    {
        OpreacionesAritmeticas Operaciones = new OpreacionesAritmeticas();
        private double PrimeraCantidad;
        private double SegundaCantidad;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            PrimeraCantidad = Convert.ToDouble(txtprimeraCantidad.Text);
            SegundaCantidad = Convert.ToDouble(txtsegundaCantidad.Text);
            txtResultado.Text = Convert.ToString(Operaciones.Suma(PrimeraCantidad,SegundaCantidad));
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            PrimeraCantidad = Convert.ToDouble(txtprimeraCantidad.Text);
            SegundaCantidad = Convert.ToDouble(txtsegundaCantidad.Text);
            txtResultado.Text = Convert.ToString(Operaciones.Resta(PrimeraCantidad,SegundaCantidad));
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            PrimeraCantidad = Convert.ToDouble(txtprimeraCantidad.Text);
            SegundaCantidad = Convert.ToDouble(txtsegundaCantidad.Text);
            txtResultado.Text = Convert.ToString(Operaciones.Multiplicacion(PrimeraCantidad, SegundaCantidad));

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            PrimeraCantidad = Convert.ToDouble(txtprimeraCantidad.Text);
            SegundaCantidad = Convert.ToDouble(txtsegundaCantidad.Text);
            txtResultado.Text = Convert.ToString(Operaciones.Division(PrimeraCantidad, SegundaCantidad));

        }
    }
}
