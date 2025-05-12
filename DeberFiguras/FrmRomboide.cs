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
    public partial class FrmRomboide : Form
    {
        private static FrmRomboide instance;
        private Romboide obj = new Romboide();
        public FrmRomboide()
        {
            InitializeComponent();
        }

        public static FrmRomboide getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRomboide();
            }
            return instance;
        }

        private void FrmRomboide_Load(object sender, EventArgs e)
        {
            obj.ReiniciarCampos(txtBase, txtAltura, txtOblicuo, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.romboide;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (obj.LeerYValidarDatos(txtBase, txtAltura, txtOblicuo))
            {
                obj.CalcularArea();
                obj.CalcularPerimetro();
                obj.MostrarResultados(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            obj.ReiniciarCampos(txtBase, txtAltura, txtOblicuo, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.CloseForm(this);
        }
    }
}
