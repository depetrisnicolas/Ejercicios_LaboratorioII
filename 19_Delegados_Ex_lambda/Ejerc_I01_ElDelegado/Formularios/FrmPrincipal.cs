namespace Formularios
{
    public partial class FrmPrincipal : Form
    {
        private FrmTestDelegados frmTestDelegados;
        private FrmMostrar frmMostrar;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.frmMostrar = new FrmMostrar();
            this.frmMostrar.MdiParent = this;
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;

        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmMostrar.Show();
        }
    }
}