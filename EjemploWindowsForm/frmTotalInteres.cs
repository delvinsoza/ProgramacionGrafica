using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploWindowsForm
{
    public partial class frmTotalInteres : Form
    {
        public delegate void pasar(string capital);
        public event pasar pasado;

        public frmTotalInteres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            pasado(CalacularInteres());
            this.Dispose();
        }

        private string CalacularInteres()
        {
            //Declaracion de variables
            double capital, razon, tiempo;
            double interes, monto;

            capital = double.Parse(txtCapital.Text);
            razon = double.Parse(txtRazon.Text);
            tiempo = double.Parse(txtTiempo.Text);

            return Convert.ToString(interes);
        }
    }
}
