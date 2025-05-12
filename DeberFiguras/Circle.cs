using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberFiguras
{
    public class Circle
    {
        private float radio;
        private float perimetro;
        private float area;

        public Circle()
        {
            radio = 0.0f;
            perimetro = 0.0f;
            area = 0.0f;
        }

        public bool LeerYValidarDatos(TextBox txtRadio)
        {

            if (string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("El radio es obligatorio.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRadio.Focus();
                return false;
            }

    
            if (!float.TryParse(txtRadio.Text, out radio) || radio <= 0)
            {
                MessageBox.Show("Ingrese un número positivo mayor que cero.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRadio.SelectAll();
                return false;
            }

            return true;
        }

       
        public void CalcularPerimetro()
        {
            perimetro = 2 * (float)Math.PI * radio;
        }

        
        public void CalcularArea()
        {
            area = (float)Math.PI * radio * radio;
        }

        
        public void MostrarResultados(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = perimetro.ToString("0.00");
            txtArea.Text = area.ToString("0.00");
        }

       
        public void ReiniciarCampos(TextBox txtRadio, TextBox txtPerimetro, TextBox txtArea)
        {
            radio = perimetro = area = 0.0f;
            txtRadio.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            txtRadio.Focus();
        }
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
