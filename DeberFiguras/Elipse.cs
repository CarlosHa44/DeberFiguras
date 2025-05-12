using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberFiguras
{
    public class Elipse
    {
        private float semiejeMayor;
        private float semiejeMenor;
        private float perimetro;
        private float area;

        public Elipse()
        {
            semiejeMayor = 0.0f;
            semiejeMenor = 0.0f;
            perimetro = 0.0f;
            area = 0.0f;
        }

        public bool LeerYValidarDatos(TextBox txtSemiejeMayor, TextBox txtSemiejeMenor)
        {

            if (string.IsNullOrWhiteSpace(txtSemiejeMayor.Text) ||
                string.IsNullOrWhiteSpace(txtSemiejeMenor.Text))
            {
                MessageBox.Show("Ambos semiejes son obligatorios.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!float.TryParse(txtSemiejeMayor.Text, out semiejeMayor) ||
                !float.TryParse(txtSemiejeMenor.Text, out semiejeMenor) ||
                semiejeMayor <= 0 || semiejeMenor <= 0)
            {
                MessageBox.Show("Ingrese números positivos mayores que cero.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (semiejeMenor > semiejeMayor)
            {
                MessageBox.Show("El semieje mayor debe ser igual o mayor al menor.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        
        public void CalcularArea()
        {
            area = (float)Math.PI * semiejeMayor * semiejeMenor;
        }

        public void CalcularPerimetro()
        {
            float h = (float)Math.Pow((semiejeMayor - semiejeMenor) / (semiejeMayor + semiejeMenor), 2);
            perimetro = (float)(Math.PI * (semiejeMayor + semiejeMenor) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
        }


        public void MostrarResultados(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = perimetro.ToString("0.00");
            txtArea.Text = area.ToString("0.00");
        }

        public void ReiniciarCampos(TextBox txtSemiejeMayor, TextBox txtSemiejeMenor,
                                   TextBox txtPerimetro, TextBox txtArea)
        {
            semiejeMayor = semiejeMenor = perimetro = area = 0.0f;
            txtSemiejeMayor.Clear();
            txtSemiejeMenor.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            txtSemiejeMayor.Focus();
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
