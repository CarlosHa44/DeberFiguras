using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberFiguras
{
    class Triangulo
    {
        private float ladoA;
        private float ladoB;
        private float ladoC;
        private float perimetro;
        private float area;

        public Triangulo()
        {
            ladoA = ladoB = ladoC = 0.0f;
            perimetro = area = 0.0f;
        }

        public bool ReadAndValidateData(TextBox txtA, TextBox txtB, TextBox txtC)
        {
            float a, b, c;
            // Intentar parsear
            try
            {
                a = float.Parse(txtA.Text);
                b = float.Parse(txtB.Text);
                c = float.Parse(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido: asegúrate de ingresar números.", "Error de Entrada");
                return false;
            }

            // Validar valores positivos
            if (a <= 0 || b <= 0 || c <= 0)
            {
                MessageBox.Show("Los lados deben ser mayores que cero.", "Error de Validación");
                return false;
            }

            // Validar desigualdad triangular
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("Los valores ingresados no cumplen la desigualdad triangular.", "Error de Validación");
                return false;
            }

            // Asignar valores si todo es válido
            ladoA = a;
            ladoB = b;
            ladoC = c;
            return true;
        }

        public void calculatePerimeter()
        {
            perimetro = ladoA + ladoB + ladoC;
        }

        public void calculateArea()
        {
            // Fórmula de Herón
            float s = perimetro / 2.0f;
            float bajoRaiz = s * (s - ladoA) * (s - ladoB) * (s - ladoC);

            if (bajoRaiz < 0)
            {
                MessageBox.Show("Los lados no forman un triángulo válido.", "Error de Cálculo");
                area = 0.0f;
            }
            else
            {
                area = (float)Math.Sqrt(bajoRaiz);
            }
        }

        public void printData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = perimetro.ToString();
            txtArea.Text = area.ToString();
        }

        public void initializeData(
            TextBox txtA, TextBox txtB, TextBox txtC,
            TextBox txtPerimetro, TextBox txtArea)
        {
            ladoA = ladoB = ladoC = 0.0f;
            perimetro = area = 0.0f;

            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtA.Focus();
            
        }

        public void closeForm(Form frm)
        {
            frm.Close();
        }
    }
}
