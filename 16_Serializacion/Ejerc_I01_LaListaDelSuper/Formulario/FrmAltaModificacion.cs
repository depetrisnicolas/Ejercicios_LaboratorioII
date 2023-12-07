namespace Formularios
{
    public partial class FrmAltaModificacion : Form
    {


        public FrmAltaModificacion(string titulo, string textoObjeto, string textoBtnConfirmar)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = titulo;
            this.txtObjeto.Text = textoObjeto;
            this.btnConfirmar.Text = textoBtnConfirmar;
        }

        public string Objeto
        {
            get
            {
                return this.txtObjeto.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void Confirmar()
        {
            if (string.IsNullOrWhiteSpace(this.Objeto))
            {
                MessageBox.Show("Aun no se guardó ningún elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Confirmar();
            }
            else if (e.KeyChar == (char)27)
            {
                Cancelar();
            }
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {

        }
    }
}