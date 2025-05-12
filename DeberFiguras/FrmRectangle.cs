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
    public partial class FrmRectangle : Form
    {
        private static FrmRectangle instance;
        private Rectangulo obj = new Rectangulo();
        public FrmRectangle()
        {
            InitializeComponent();
        }

        public static FrmRectangle getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRectangle();
            }
            return instance;
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            obj.ReiniciarCalculadora(txtBase, txtAltura, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.rectangulo;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (obj.ValidarDimensiones(txtBase, txtAltura))
            {
                obj.CalcularPerimetro();
                obj.CalcularArea();
                obj.MostrarResultados(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            obj.ReiniciarCalculadora(txtBase, txtAltura, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.CloseForm(this);
        }
    }
}
