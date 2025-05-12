using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberFiguras
{
    public class Rectangulo
    {
        private float ancho;
        private float alto;
        private float perimetro;
        private float area;

        public Rectangulo()
        {
            ancho = 0.0f;
            alto = 0.0f;
            perimetro = 0.0f;
            area = 0.0f;
        }

        public bool ValidarDimensiones(TextBox txtAncho, TextBox txtAlto)
        {
          
            if (string.IsNullOrWhiteSpace(txtAncho.Text))
            {
                MessageBox.Show("Debe ingresar la longitud del ancho", "Campo requerido",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAncho.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAlto.Text))
            {
                MessageBox.Show("Debe ingresar la longitud del alto", "Campo requerido",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAlto.Focus();
                return false;
            }

            
            if (!float.TryParse(txtAncho.Text, out ancho) || ancho <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico positivo para el ancho", "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAncho.SelectAll();
                txtAncho.Focus();
                return false;
            }
            if (!float.TryParse(txtAlto.Text, out alto) || alto <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico positivo para el alto", "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAlto.SelectAll();
                txtAlto.Focus();
                return false;
            }

            return true;
        }

        
        public void CalcularPerimetro()
        {
            perimetro = 2 * (ancho + alto);
        }

        
        public void CalcularArea()
        {
            area = ancho * alto;
        }

        
        public void MostrarResultados(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = $"{perimetro:0.##}";
            txtArea.Text = $"{area:0.##}";
        }

       
        public void ReiniciarCalculadora(TextBox txtAncho, TextBox txtAlto, TextBox txtPerimetro, TextBox txtArea)
        {
            ancho = alto = perimetro = area = 0.0f;
            txtAncho.Clear();
            txtAlto.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            txtAncho.Focus();
        }
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
