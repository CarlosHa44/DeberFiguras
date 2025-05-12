using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberFiguras
{
    public partial class FrmTriangulo : Form
    {
        private static FrmTriangulo instance;
        private Triangulo obj = new Triangulo();
        public FrmTriangulo()
        {
            InitializeComponent();
        }

        public static FrmTriangulo getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTriangulo();
            }

            return instance;
        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {
            obj.initializeData(txtLado1, txtLado2, txtLado3, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.triangulo;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (obj.ReadAndValidateData(txtLado1, txtLado2, txtLado3))
            {
                obj.calculatePerimeter();
                obj.calculateArea();
                obj.printData(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            obj.initializeData(txtLado1, txtLado2, txtLado3, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.closeForm(this);
        }
    }
}
