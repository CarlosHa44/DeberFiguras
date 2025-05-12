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
    public partial class FrmCuadrado : Form
    {
        private static FrmCuadrado instance;
        private Cuadrado obj = new Cuadrado();
        public FrmCuadrado()
        {
            InitializeComponent();
        }
        public static FrmCuadrado getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCuadrado();
            }
            return instance;
        }

        private void FrmCuadrado_Load(object sender, EventArgs e)
        {
            obj.ReiniciarCalculadora(txtSize, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.cuadrado;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (obj.ValidarLado(txtSize))
            {
                obj.CalcularPerimetro();
                obj.CalcularArea();
                obj.MostrarResultados(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            obj.ReiniciarCalculadora(txtSize, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.CloseForm(this);
        }
    }
}
