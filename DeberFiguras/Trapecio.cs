using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberFiguras
{
    public class Trapecio
    {
        private float baseMayor;
        private float baseMenor;
        private float altura;
        private float perimetro;
        private float area;

        public Trapecio()
        {
            baseMayor = 0.0f;
            baseMenor = 0.0f;
            altura = 0.0f;
            perimetro = 0.0f;
            area = 0.0f;
        }

        public bool ValidarDatos(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura)
        {
            
            if (string.IsNullOrWhiteSpace(txtBaseMayor.Text) ||
                !float.TryParse(txtBaseMayor.Text, out baseMayor) ||
                baseMayor <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico positivo para la base mayor",
                               "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBaseMayor.Focus();
                return false;
            }

            
            if (string.IsNullOrWhiteSpace(txtBaseMenor.Text) ||
                !float.TryParse(txtBaseMenor.Text, out baseMenor) ||
                baseMenor <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico positivo para la base menor",
                               "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBaseMenor.Focus();
                return false;
            }

            
            if (baseMayor <= baseMenor)
            {
                MessageBox.Show("La base mayor debe ser mayor que la base menor",
                               "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBaseMayor.Focus();
                return false;
            }

            
            if (string.IsNullOrWhiteSpace(txtAltura.Text) ||
                !float.TryParse(txtAltura.Text, out altura) ||
                altura <= 0)
            {
                MessageBox.Show("Ingrese un valor numérico positivo para la altura",
                               "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
                return false;
            }

            return true;
        }

       
        public void CalcularPerimetro()
        {
            
            float distanciaBasesMedios = (baseMayor - baseMenor) / 2;
            float lado = (float)Math.Sqrt(Math.Pow(distanciaBasesMedios, 2) + Math.Pow(altura, 2));

            perimetro = baseMayor + baseMenor + (2 * lado);
        }

        
        public void CalcularArea()
        {
            area = (baseMayor + baseMenor) * altura / 2;
        }

       
        public void MostrarResultados(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = $"{perimetro:0.##}";
            txtArea.Text = $"{area:0.##}";
        }

       
        public void ReiniciarCalculadora(TextBox txtBaseMayor, TextBox txtBaseMenor,
                                        TextBox txtAltura, TextBox txtPerimetro,
                                        TextBox txtArea)
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
