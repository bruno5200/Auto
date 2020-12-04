using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentación
{
    public partial class FormArchivos : Form
    {

        public FormArchivos()
        {
            InitializeComponent();
            CargarArchivos();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarArchivos()
        {
            CN_Auto Archivos = new CN_Auto();
            DataTable archivo = new DataTable();
            tblArchivo.DataSource = Archivos.ListarArchivos(archivo);
        }
    }
}
