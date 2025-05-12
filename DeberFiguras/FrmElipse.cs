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
    public partial class FrmElipse : Form
    {
        private static FrmElipse instance;
        private Elipse obj = new Elipse();
        public FrmElipse()
        {
            InitializeComponent();
        }

        public static FrmElipse getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmElipse();
            }
            return instance;
        }

        private void FrmElipse_Load(object sender, EventArgs e)
        {
            obj.ReiniciarCampos(txtSemiMayor, txtSemiMenor, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.elipse;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (obj.LeerYValidarDatos(txtSemiMayor, txtSemiMenor))
            {
                obj.CalcularPerimetro();
                obj.CalcularArea();
                obj.MostrarResultados(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            obj.ReiniciarCampos(txtSemiMayor, txtSemiMenor, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.CloseForm(this);
        }
    }
}
