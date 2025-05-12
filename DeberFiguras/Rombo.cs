using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberFiguras
{
    public class Rombo
    {
        private float diagonal1;
        private float diagonal2;
        private float perimeter;
        private float area;
        private float side;

        public Rombo()
        {
            diagonal1 = 0.0f;
            diagonal2 = 0.0f;
            perimeter = 0.0f;
            area = 0.0f;
            side = 0.0f;
        }

        public void ReadData(TextBox txtDiagonal1, TextBox txtDiagonal2)
        {
            try
            {
                diagonal1 = float.Parse(txtDiagonal1.Text);
                diagonal2 = float.Parse(txtDiagonal2.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalculatePerimeter()
        {
            side = (float)Math.Sqrt(Math.Pow(diagonal1 / 2, 2) + Math.Pow(diagonal2 / 2, 2));
            perimeter = 4 * side;
        }

        public void CalculateArea()
        {
            area = (diagonal1 * diagonal2) / 2;
        }

        public void DisplayResults(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        public void ClearFields(TextBox txtDiagonal1, TextBox txtDiagonal2, TextBox txtPerimeter, TextBox txtArea)
        {
            diagonal1 = diagonal2 = perimeter = area = side = 0.0f;
            txtDiagonal1.Clear();
            txtDiagonal2.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            txtDiagonal1.Focus();
        }
        public void closeForm(Form frm)
        {
            frm.Close();
        }
    }
}