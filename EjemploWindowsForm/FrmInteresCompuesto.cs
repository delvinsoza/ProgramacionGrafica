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
    public partial class FrmInteresCompuesto : Form
    {
        public FrmInteresCompuesto()
        {
            InitializeComponent();
        }

        private void FrmInteresCompuesto_Load(object sender, EventArgs e)
        {

        }

        private void txtTotalInteres_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter);
            {
                frmTotalInteres frmTotal = new frmTotalInteres();
               // frmTotal.pasado += new frmTotalInteres.pasar;
            }
        }
    }
}
