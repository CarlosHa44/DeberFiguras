using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberFiguras
{
    public class Romboide
    {
        private float baseRomboide;
        private float altura;
        private float ladoOblicuo;
        private float perimetro;
        private float area;

        public Romboide()
        {
            baseRomboide = 0.0f;
            altura = 0.0f;
            ladoOblicuo = 0.0f;
            perimetro = 0.0f;
            area = 0.0f;
        }


        public bool LeerYValidarDatos(TextBox txtBase, TextBox txtAltura, TextBox txtLadoOblicuo)
        {
            if (string.IsNullOrWhiteSpace(txtBase.Text) ||
                string.IsNullOrWhiteSpace(txtAltura.Text) ||
                string.IsNullOrWhiteSpace(txtLadoOblicuo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!float.TryParse(txtBase.Text, out baseRomboide) ||
                !float.TryParse(txtAltura.Text, out altura) ||
                !float.TryParse(txtLadoOblicuo.Text, out ladoOblicuo) ||
                baseRomboide <= 0 || altura <= 0 || ladoOblicuo <= 0)
            {
                MessageBox.Show("Ingrese números positivos mayores que cero.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }


        public void CalcularArea()
        {
            area = baseRomboide * altura;
        }


        public void CalcularPerimetro()
        {
            perimetro = 2 * (baseRomboide + ladoOblicuo);
        }

       
        public void MostrarResultados(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = perimetro.ToString("0.00");
            txtArea.Text = area.ToString("0.00");
        }

      
        public void ReiniciarCampos(TextBox txtBase, TextBox txtAltura, TextBox txtLadoOblicuo,
                                   TextBox txtPerimetro, TextBox txtArea)
        {
            baseRomboide = altura = ladoOblicuo = perimetro = area = 0.0f;
            txtBase.Clear();
            txtAltura.Clear();
            txtLadoOblicuo.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            txtBase.Focus();
        }
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
