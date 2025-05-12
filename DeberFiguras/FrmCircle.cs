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
    public partial class FrmCircle : Form
    {
        private static FrmCircle instance;
        private Circle obj = new Circle();
        public FrmCircle()
        {
            InitializeComponent();
        }

        public static FrmCircle getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCircle();
            }
            return instance;
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            obj.ReiniciarCampos(txtRadio, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.circulo;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (obj.LeerYValidarDatos(txtRadio))
            {
                obj.CalcularPerimetro();
                obj.CalcularArea();
                obj.MostrarResultados(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            obj.ReiniciarCampos(txtRadio, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.CloseForm(this);
        }
    }
}
