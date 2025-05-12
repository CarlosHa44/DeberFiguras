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
    public partial class FrmPoligonos : Form
    {
        private static FrmPoligonos instance;
        private Poligono objPoli = new Poligono();
        public FrmPoligonos()
        {
            InitializeComponent();
        }

        public static FrmPoligonos getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmPoligonos();
            }
            return instance;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objPoli.ReadData(txtSizes, txtLenght);
            objPoli.calculateApotema();
            objPoli.calculatePerimeter();
            objPoli.calculateArea();
            objPoli.printData(txtPerimeter, txtArea);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objPoli.initializeData(txtPerimeter, txtArea, txtSizes, txtLenght);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objPoli.closeForm(this);
        }

        private void FrmPoligonos_Load(object sender, EventArgs e)
        {
            objPoli.initializeData(txtPerimeter, txtArea, txtSizes, txtLenght);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.Image = Properties.Resources.Poligonos;
        }
    }
}
