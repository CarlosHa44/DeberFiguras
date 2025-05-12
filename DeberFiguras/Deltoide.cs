using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberFiguras
{
    public class Deltoide
    {
        private float diagonalMayor;  
        private float diagonalMenor; 
        private float perimetro;
        private float area;
        private float ladoLargo;    
        private float ladoCorto;    

        public Deltoide()
        {
            diagonalMayor = 0.0f;
            diagonalMenor = 0.0f;
            perimetro = 0.0f;
            area = 0.0f;
            ladoLargo = 0.0f;
            ladoCorto = 0.0f;
        }

        public void LeerDatos(TextBox txtDiagonalMayor, TextBox txtDiagonalMenor)
        {
            try
            {
                diagonalMayor = float.Parse(txtDiagonalMayor.Text);
                diagonalMenor = float.Parse(txtDiagonalMenor.Text);
            }
            catch
            {
                MessageBox.Show("Entrada no válida. Ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public void CalcularArea()
        {
            area = (diagonalMayor * diagonalMenor) / 2;
        }

        
        public void CalcularPerimetro()
        {
            
            ladoLargo = (float)Math.Sqrt(Math.Pow(diagonalMayor / 2, 2) + Math.Pow(diagonalMenor / 2, 2));
            ladoCorto = (float)Math.Sqrt(Math.Pow(diagonalMayor / 2, 2) + Math.Pow(diagonalMenor / 4, 2)); 
            perimetro = 2 * (ladoLargo + ladoCorto);
        }

        
        public void MostrarResultados(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = perimetro.ToString("0.00");
            txtArea.Text = area.ToString("0.00");
        }

        
        public void ReiniciarCampos(TextBox txtDiagonalMayor, TextBox txtDiagonalMenor, TextBox txtPerimetro, TextBox txtArea)
        {
            diagonalMayor = diagonalMenor = perimetro = area = ladoLargo = ladoCorto = 0.0f;
            txtDiagonalMayor.Clear();
            txtDiagonalMenor.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();
            txtDiagonalMayor.Focus();
        }

        public void closeForm(Form form)
        {
            form.Close();
        }
    }
}
