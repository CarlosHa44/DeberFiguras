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
    public partial class FrmTrapecioIsoceles : Form
    {
        private static FrmTrapecioIsoceles instance;
        private TrapecioIsoceles obj = new TrapecioIsoceles();
        public FrmTrapecioIsoceles()
        {
            InitializeComponent();
        }

        public static FrmTrapecioIsoceles getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTrapecioIsoceles();
            }
            return instance;
        }

        private void FrmTrapecioIsoceles_Load(object sender, EventArgs e)
        {
            obj.ReiniciarControles(txtBaseMayor, txtBaseMenor, txtAltura, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.trapecioIso;
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
            obj.ReiniciarControles(txtBaseMayor, txtBaseMenor, txtAltura, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            obj.CloseForm(this);
        }
    }
}
