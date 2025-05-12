using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberFiguras
{
    class Poligono
    {
        private float pSizes;
        private float pLength;
        private float pPerimeter;
        private float pArea;
        private float pApotema;

        public Poligono()
        {
            pSizes = 0.0f;
            pLength = 0.0f;
            pPerimeter = 0.0f;
            pArea = 0.0f;
            pApotema = 0.0f;
        }

        public bool ReadData(TextBox txtSizes, TextBox txtLength)
        {
            
            if (string.IsNullOrWhiteSpace(txtSizes.Text) || string.IsNullOrWhiteSpace(txtLength.Text))
            {
                MessageBox.Show("Ambos campos son obligatorios", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!float.TryParse(txtSizes.Text, out pSizes) ||
                !float.TryParse(txtLength.Text, out pLength) ||
                pSizes <= 0 || pLength <= 0)
            {
                MessageBox.Show("Ingrese números positivos mayores que cero", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                if (pSizes <= 0) txtSizes.SelectAll();
                if (pLength <= 0) txtLength.SelectAll();

                return false;
            }

            return true; 
        }

        public void calculateApotema()
        {
            pApotema = (float)(pLength / (2 * Math.Tan(Math.PI / pSizes)));
        }

        public void calculatePerimeter()
        {
            pPerimeter = pSizes * pLength;
        }

        public void calculateArea()
        {
            pArea = (pPerimeter*pApotema) / 2;        
        }

        public void printData(TextBox txtPerimeter,TextBox txtArea)
        {
            txtPerimeter.Text = pPerimeter.ToString();
            txtArea.Text = pArea.ToString();
        }

        public void initializeData(TextBox txtPerimeter,TextBox txtArea,TextBox txtSizes,TextBox txtLength)
        {
            pSizes = 0.0f;
            pLength = 0.0f;
            pPerimeter = 0.0f;
            pArea = 0.0f;
            pApotema = 0.0f;

            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSizes.Text = "";
            txtLength.Text = "";
            txtSizes.Focus();
        }

        public void closeForm(Form frm)
        {
            frm.Close();
        }
    }
}
