using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.C_Presentacion
{
    internal class Validador
    {
        public Validador() { }
        public bool validarCampo(ErrorProvider ep, TextBox tb, int logitud_min = 0)
        {
            ep.Clear();
            if (string.IsNullOrEmpty(tb.Text))
            {
                ep.SetError(tb, "Este campo es requerido");
                return false;
            }

            if (tb.TextLength < logitud_min)
            {
                ep.SetError(tb, $"Este campo debe tener al menos {logitud_min} caracteres.");
                return false;
            }

            return true;
        }

        public bool validarCbx(ErrorProvider ep, ComboBox cbx)
        {
            ep.Clear();
            if (cbx.SelectedIndex+1 <= 0)
            {
                ep.SetError(cbx,"Seleccione una opcion valida");
                return false;
            }

            return true;
        }

        public bool validarTalles(ErrorProvider ep, TextBox tbxS, TextBox tbxM, TextBox tbxL, TextBox tbxXL)
        {
            ep.Clear();

            try
            {

                int talleS = Int32.Parse(tbxS.Text);
                int talleM = Int32.Parse(tbxM.Text);
                int talleL = Int32.Parse(tbxL.Text);
                int talleXL = Int32.Parse(tbxXL.Text);

                int stock = talleS + talleM + talleL + talleXL;

                if (stock <= 0)
                {
                    ep.SetError(tbxS, "El stock debe tener almenos un producto");
                    return false;
                }

                return true;
            }
            catch (Exception)
            {

                ep.SetError(tbxS, "Todos los campos de stock deben tener numeros");
                return false;
            }
        }
    }
}
