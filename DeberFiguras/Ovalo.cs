using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberFiguras
{
    public class Ovalo
    {
        private float radioMayor;
        private float radioMenor;
        private float perimetro;
        private float area;

        public Ovalo()
        {
            radioMayor = 0.0f;
            radioMenor = 0.0f;
            perimetro = 0.0f;
            area = 0.0f;
        }

        
        public bool ValidarInputs(TextBox txtRadioMayor, TextBox txtRadioMenor)
        {
            if (string.IsNullOrWhiteSpace(txtRadioMayor.Text) ||
                string.IsNullOrWhiteSpace(txtRadioMenor.Text))
            {
                MessageBox.Show("Ambos radios son requeridos", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!float.TryParse(txtRadioMayor.Text, out radioMayor) ||
                !float.TryParse(txtRadioMenor.Text, out radioMenor) ||
                radioMayor <= 0 || radioMenor <= 0)
            {
                MessageBox.Show("Solo valores numéricos positivos", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (radioMenor > radioMayor)
            {
                MessageBox.Show("El radio mayor debe ser ≥ al radio menor", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        
        public void CalcularArea()
        {
            area = (float)Math.PI * radioMayor * radioMenor;
        }

        
        public void CalcularPerimetro()
        {
            float h = (float)Math.Pow((radioMayor - radioMenor) / (radioMayor + radioMenor), 2);
            perimetro = (float)(Math.PI * (radioMayor + radioMenor) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
        }

        
        public void MostrarResultados(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = perimetro.ToString("0.00");
            txtArea.Text = area.ToString("0.00");
        }

        
        public void ReiniciarControles(TextBox txtRadioMayor, TextBox txtRadioMenor,TextBox txtPerimetro, TextBox txtArea)
        {
            radioMayor = radioMenor = perimetro = area = 0.0f;
            txtRadioMayor.Clear();
            txtRadioMenor.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            txtRadioMayor.Focus();
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
