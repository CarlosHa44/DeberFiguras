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
    public partial class FrmRombo : Form
    {
        private static FrmRombo instance;
        private Rombo objRombo = new Rombo();
        public FrmRombo()
        {
            InitializeComponent();
        }

        public static FrmRombo getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRombo();
            }
            return instance;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRombo.ReadData(txtDiagonal1, txtDiagonal2);
            objRombo.CalculatePerimeter();
            objRombo.CalculateArea();
            objRombo.DisplayResults(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objRombo.ClearFields(txtDiagonal1, txtDiagonal2, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objRombo.closeForm(this);
        }

        private void FrmRombo_Load(object sender, EventArgs e)
        {
            objRombo.ClearFields(txtDiagonal1, txtDiagonal2, txtPerimeter, txtArea);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.Rombo;
        }
    }
}
