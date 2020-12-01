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
        private Exception Err;
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
                UserCN.GuardarUsuario(u);
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
                AutoCN.GuardarAuto(a);

                TimeCN.GuardarTiempo(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (Err == null)
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
            foreach (DataRow items in auto.Rows)
            {
                a.Placa = Convert.ToString(items[0]);
                a.Dir = Convert.ToString(items[1]);
                a.Id = Convert.ToInt64(items[2]);
            }
            txtPlaca.Text = a.Placa;
            lblPlaca.Text = txtPlaca.Text;
            pibAuto.ImageLocation = @"C:\Users\user\Desktop\Proyecto Auto\Auto\ProbandoOCR" + a.Dir; 
            //pibAuto.ImageLocation = @"G:\GIT\Auto\ProbandoOCR" + a.Dir;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letrasSeparator(e);
        }

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }
    }
}