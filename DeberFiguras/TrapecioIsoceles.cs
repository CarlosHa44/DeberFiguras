using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberFiguras
{
    public class TrapecioIsoceles
    {
        private float baseMayor;
        private float baseMenor;
        private float altura;
        private float ladoOblicuo;
        private float perimetro;
        private float area;

        public TrapecioIsoceles()
        {
            baseMayor = 0.0f;
            baseMenor = 0.0f;
            altura = 0.0f;
            ladoOblicuo = 0.0f;
            perimetro = 0.0f;
            area = 0.0f;
        }

        
        public bool ValidarDatos(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura)
        {
            
            if (string.IsNullOrWhiteSpace(txtBaseMayor.Text) ||
                string.IsNullOrWhiteSpace(txtBaseMenor.Text) ||
                string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                MessageBox.Show("Todos los campos son requeridos", "Datos incompletos",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            if (!float.TryParse(txtBaseMayor.Text, out baseMayor) ||
                !float.TryParse(txtBaseMenor.Text, out baseMenor) ||
                !float.TryParse(txtAltura.Text, out altura) ||
                baseMayor <= 0 || baseMenor <= 0 || altura <= 0)
            {
                MessageBox.Show("Ingrese valores numéricos positivos", "Datos inválidos",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            if (baseMayor <= baseMenor)
            {
                MessageBox.Show("La base mayor debe ser más grande que la base menor", "Relación incorrecta",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        
        private void CalcularLadoOblicuo()
        {
            float diferenciaBases = (baseMayor - baseMenor) / 2;
            ladoOblicuo = (float)Math.Sqrt(Math.Pow(diferenciaBases, 2) + Math.Pow(altura, 2));
        }

       
        public void CalcularPerimetro()
        {
            CalcularLadoOblicuo();
            perimetro = baseMayor + baseMenor + (2 * ladoOblicuo);
        }

        
        public void CalcularArea()
        {
            area = ((baseMayor + baseMenor) * altura) / 2;
        }

        
        public void MostrarResultados(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = $"{perimetro:0.##}";
            txtArea.Text = $"{area:0.##}";
        }

        
        public void ReiniciarControles(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura,
                                     TextBox txtPerimetro, TextBox txtArea)
        {
            baseMayor = baseMenor = altura = perimetro = area = 0.0f;
            txtBaseMayor.Clear();
            txtBaseMenor.Clear();
            txtAltura.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            txtBaseMayor.Focus();
        }
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
