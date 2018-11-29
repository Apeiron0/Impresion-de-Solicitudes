using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solicitudes
{
    public partial class frm_Inicio : Form
    {
        public frm_Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Kups form = new frm_Kups();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_CintasNegras frm_CintasNegras = new frm_CintasNegras();
            frm_CintasNegras.ShowDialog();
        }
    }
}
