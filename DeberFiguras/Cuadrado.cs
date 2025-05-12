using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberFiguras
{
    public class Cuadrado
    {
        private float lado;
        private float perimetro;
        private float area;

        public Cuadrado()
        {
            lado = 0.0f;
            perimetro = 0.0f;
            area = 0.0f;
        }

        public bool ValidarLado(TextBox txtLado)
        {
            if (string.IsNullOrWhiteSpace(txtLado.Text))
            {
                MessageBox.Show("Debe ingresar la longitud del lado", "Campo requerido",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLado.Focus();
                return false;
            }

            if (!float.TryParse(txtLado.Text, out lado) || lado <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLado.SelectAll();
                return false;
            }

            return true;
        }

        public void CalcularPerimetro()
        {
            perimetro = 4 * lado;
        }


        public void CalcularArea()
        {
            area = lado * lado;
        }

        public void MostrarResultados(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = $"{perimetro:0.##}";
            txtArea.Text = $"{area:0.##}";
        }

        public void ReiniciarCalculadora(TextBox txtLado, TextBox txtPerimetro, TextBox txtArea)
        {
            lado = perimetro = area = 0.0f;
            txtLado.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            txtLado.Focus();
        }
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
