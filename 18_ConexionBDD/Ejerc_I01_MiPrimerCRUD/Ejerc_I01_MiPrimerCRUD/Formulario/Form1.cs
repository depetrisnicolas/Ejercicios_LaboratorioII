using Entidades;
using Entidades.excepciones;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstPersonas.SelectedItem != null)
            {
                Persona personaSeleccionada = (Persona)this.lstPersonas.SelectedItem;
                this.txtNombre.Text = personaSeleccionada.Nombre;
                this.txtApellido.Text = personaSeleccionada.Apellido;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtApellido.Text))
            {
                Persona nuevaPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text);
                PersonaDAO.Guardar(nuevaPersona);
            }
        }

        private void CargarListaPersonas()
        {
            this.lstPersonas.Items.Clear();
            List<Persona> personas = PersonaDAO.Leer();
            foreach (Persona persona in personas)
            {
                this.lstPersonas.Items.Add(persona);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstPersonas.SelectedItem != null)
            {
                Persona personaSeleccionada = (Persona)this.lstPersonas.SelectedItem;

                if (!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtApellido.Text))
                {
                    Persona personaEditada = new Persona(this.txtNombre.Text, this.txtApellido.Text);
                    PersonaDAO.Modificar(personaEditada, personaSeleccionada.Id);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstPersonas.SelectedItem != null)
            {
                Persona personaSeleccionada = (Persona)this.lstPersonas.SelectedItem;
                PersonaDAO.Borrar(personaSeleccionada.Id);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarListaPersonas();
            }
            catch (BaseDeDatosException)
            {
                MessageBox.Show("No hay ningún elemento para leer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}