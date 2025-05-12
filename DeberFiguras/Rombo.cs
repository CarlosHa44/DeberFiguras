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

        public bool ReadData(TextBox txtDiagonal1, TextBox txtDiagonal2)
        {
           
            diagonal1 = diagonal2 = 0f;

           
            if (string.IsNullOrWhiteSpace(txtDiagonal1.Text) || string.IsNullOrWhiteSpace(txtDiagonal2.Text))
            {
                MessageBox.Show("Both diagonals are required", "Missing Data",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiagonal1.Focus();
                return false;
            }

            if (!float.TryParse(txtDiagonal1.Text, out diagonal1) ||
                !float.TryParse(txtDiagonal2.Text, out diagonal2))
            {
                MessageBox.Show("Only numeric values are allowed", "Invalid Input",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiagonal1.SelectAll();
                txtDiagonal2.SelectAll();
                return false;
            }

            
            if (diagonal1 <= 0 || diagonal2 <= 0)
            {
                MessageBox.Show("Diagonals must be greater than zero", "Invalid Value",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (diagonal1 <= 0) txtDiagonal1.SelectAll();
                if (diagonal2 <= 0) txtDiagonal2.SelectAll();

                return false;
            }

            return true;
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