using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentación
{
    public partial class FormRegistrar : Form
    {
        private CN_Auto AutoCN = new CN_Auto();
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void btnEditarPlaca_Click(object sender, EventArgs e)
        {
            txtPlaca.Visible = true;
            lblMatricula.Visible = true;
        }
    }
}
