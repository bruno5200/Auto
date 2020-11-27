using System;
using System.Windows.Forms;

namespace CapaPresentación
{
    public class Validate
    {
        public void letras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))// esta nstruccion nos permtira borrar y modificarlos que escribimos en el text box
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduzca sólo caracteres Alfabeticos" + ex.Message);
            }
        }
        public void letrasSeparator(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))// esta nstruccion nos permtira borrar y modificar lo que escribimos en el text box
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))//esta instruccion nos permite poner separadores
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduzca sólo caracteres Alfabeticos sin espacios" + ex.Message);
            }
        }
        public void numeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar)) //si la tecla presonada conrresponde a un numero la admite
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))// esta nstruccion nos permtira borrar y modificar lo que escribimos en el text box
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduzca sólo caracteres Númericos" + ex.Message);
            }
        }
        public void alphanumerco(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar)) //si la tecla presonada conrresponde a un numero la admite
                {
                    e.Handled = false;
                }
                else if (char.IsLetter(e.KeyChar))// tambien admitira letras
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))// esta instruccion nos permtira borrar y modificar lo que escribimos en el text box
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))//esta instruccion nos permite poner separadores
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduzca sólo caracteres Númericos o Alfabeticos sin Espacios" + ex.Message);
            }
        }
    }
}
