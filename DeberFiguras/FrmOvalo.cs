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
    public partial class FrmOvalo : Form
    {
        private static FrmOvalo instance;
        private Ovalo obj = new Ovalo();
        public FrmOvalo()
        {
            InitializeComponent();
        }

        public static FrmOvalo getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmOvalo();
            }
            return instance;
        }

        private void FrmOvalo_Load(object sender, EventArgs e)
        {
            obj.ReiniciarControles(txtRadioMayor, txtRadioMenor, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.ovalo;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (obj.ValidarInputs(txtRadioMayor, txtRadioMenor))
            {
                obj.CalcularPerimetro();
                obj.CalcularArea();
                obj.MostrarResultados(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            obj.ReiniciarControles(txtRadioMayor, txtRadioMenor, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.CloseForm(this);
        }
    }
}
