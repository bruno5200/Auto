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
using CapaEntidades;

namespace CapaPresentación
{
    public partial class FormRegistrar : Form
    {
        private CE_User u = new CE_User();
        private CE_Auto a = new CE_Auto();
        private CE_Time t = new CE_Time();
        private Validate v = new Validate();
        private CN_Auto AutoCN = new CN_Auto();
        private CN_Usuario UserCN = new CN_Usuario();
        private CN_Tiempo TimeCN = new CN_Tiempo();

        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void btnEditarPlaca_Click(object sender, EventArgs e)
        {
            txtPlaca.Visible = true;
            lblMatricula.Visible = true;
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                u.Cedula = txtCI.Text;
                u.Nombre = txtName.Text;
                t = UserCN.GuardarUsuario(u, t);
            }
            catch (Exception ex)
            {

            }
            btnGuardarVehiculo.Enabled = true;
        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                a.Placa = txtPlaca.Text;
                a.Marca = txtMarca.Text;
                a.Tipo = txtTipo.Text;
                a.Color = txtColor.Text;
                t = AutoCN.GuardarAuto(a, t);
                TimeCN.GuardarTiempo(t);
            }
            catch (Exception ex)
            {

            }
            btnGuardarVehiculo.Enabled = false;
        }
        public void DatosUpdate(CE_Auto a, CE_User u)
        {
            txtMarca.Text = a.Marca;
            txtColor.Text = a.Color;
            txtTipo.Text = a.Tipo;

            txtName.Text = u.Nombre;
            txtCI.Text = u.Cedula;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable auto = new DataTable();
            auto = AutoCN.ObtenerAuto(auto);
            a.Placa = Convert.ToString(auto.Rows[1]);
            a.Dir = Convert.ToString(auto.Rows[2]);
            a.Id = Convert.ToInt64(auto.Rows[3]);
            txtPlaca.Text = a.Placa;
            pibAuto.ImageLocation = "C:Users/jose/Desktop/Auto/AutoOCR" + a.Dir;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }
    }
}