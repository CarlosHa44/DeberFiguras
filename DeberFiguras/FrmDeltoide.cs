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
    public partial class FrmDeltoide : Form
    {
        private static FrmDeltoide instance;
        private Deltoide obj = new Deltoide();
        public FrmDeltoide()
        {
            InitializeComponent();
        }

        public static FrmDeltoide getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDeltoide();
            }
            return instance;
        }

        private void FrmDeltoide_Load(object sender, EventArgs e)
        {
            obj.ReiniciarCampos(txtDiagonalMayor, txtDiagonalMenor, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.Deltoide;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            obj.LeerDatos(txtDiagonalMayor, txtDiagonalMenor);
            obj.CalcularPerimetro();
            obj.CalcularArea();
            obj.MostrarResultados(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            obj.ReiniciarCampos(txtDiagonalMayor, txtDiagonalMenor, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.closeForm(this);
        }
    }
}
