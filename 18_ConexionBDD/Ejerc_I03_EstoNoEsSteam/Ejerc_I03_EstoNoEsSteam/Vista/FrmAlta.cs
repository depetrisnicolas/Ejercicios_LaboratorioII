using Entidades;

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            cmbUsuarios.Hide();
            lblUsuarios.Text = string.Empty;
            this.codigoJuego = codigoJuego;
            PintarForm();
        }

        private void PintarForm()
        {
            Juego juego = JuegoDAO.LeerPorId(codigoJuego);

            txtGenero.Text = juego.Genero;
            txtNombre.Text = juego.Nombre;
            nupPrecio.Value = (decimal)juego.Precio;
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            try
            {
                cmbUsuarios.DataSource = UsuarioDAO.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnGuardar.Text != "Modificar")
                {
                    Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text,
                    ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);

                    JuegoDAO.Guardar(nuevoJuego);
                }
                else
                {
                    Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text, codigoJuego,
                   ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);

                    JuegoDAO.Modificar(nuevoJuego);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
            }
        }

    }
}