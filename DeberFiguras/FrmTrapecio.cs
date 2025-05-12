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
    public partial class FrmTrapecio : Form
    {
        private static FrmTrapecio instance;
        private Trapecio obj = new Trapecio();
        public FrmTrapecio()
        {
            InitializeComponent();
        }

        public static FrmTrapecio getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTrapecio();
            }
            return instance;
        }

        private void FrmTrapecio_Load(object sender, EventArgs e)
        {
            obj.ReiniciarCalculadora(txtBaseMayor, txtBaseMenor, txtAltura, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.trapecio;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (obj.ValidarDatos(txtBaseMayor, txtBaseMenor, txtAltura))
            {
                obj.CalcularPerimetro();
                obj.CalcularArea();
                obj.MostrarResultados(txtPerimeter, txtArea);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            obj.ReiniciarCalculadora(txtBaseMayor, txtBaseMenor, txtAltura, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.CloseForm(this);
        }
    }
}
