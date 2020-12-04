using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentación
{
    public partial class FormActive : Form
    {
        private CN_Auto AutoCN = new CN_Auto();
        public FormActive()
        {
            InitializeComponent();
            CargarActivos();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarActivos()
        {
            DataTable activos = new DataTable();
            tblActivos.DataSource = AutoCN.ListarActivos(activos);
        }
    }
}
