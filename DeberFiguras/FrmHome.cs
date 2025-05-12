using System.Windows.Forms;

namespace DeberFiguras
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            FrmInicio frm = new FrmInicio();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.BringToFront();
            frm.Show();
        }

        public void loadForm(Form frm)
        {
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            frm.WindowState = FormWindowState.Normal;
            frm.BringToFront();
            frm.Show();
        }

        private void poligonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPoligonos frmPoligonos = FrmPoligonos.getInstance();
            loadForm(frmPoligonos);
        }

        private void triangulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangulo frm = FrmTriangulo.getInstance();
            loadForm(frm);
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frm = FrmRombo.getInstance();
            loadForm(frm);
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoide frm = FrmDeltoide.getInstance();
            loadForm(frm);
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRomboide frm = FrmRomboide.getInstance();
            loadForm(frm);
        }

        private void circulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCircle frm = FrmCircle.getInstance();
            loadForm(frm);
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElipse frm = FrmElipse.getInstance();
            loadForm(frm);
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadrado frm = FrmCuadrado.getInstance();
            loadForm(frm);
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangle frm = FrmRectangle.getInstance();
            loadForm(frm);
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecio frm = FrmTrapecio.getInstance();
            loadForm(frm);
        }

        private void trapecioIsolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecioIsoceles frm = FrmTrapecioIsoceles.getInstance();
            loadForm(frm);
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOvalo frm = FrmOvalo.getInstance();
            loadForm(frm);
        }
    }
}
