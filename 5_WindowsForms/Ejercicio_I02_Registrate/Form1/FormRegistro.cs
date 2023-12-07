using Entidades;

namespace Form1
{
    public partial class FormRegistro : Form
    {


        public FormRegistro()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstPaises.DataSource = new object[] { "Argentina", "Chile", "Uruguay" };
            this.rdoMasculino.Checked = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresante ingresante;
            string genero = "";
            string[] cursos = new string[3];
            int indice = 0;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                if (lstPaises.SelectedItems is not null)
                {
                    foreach (Control control in grpGenero.Controls)
                    {
                        if (control is RadioButton radioButton && radioButton.Checked)
                        {
                            genero = radioButton.Text;
                            break;
                        }
                    }
                    foreach (Control control in grpCursos.Controls)
                    {
                        if (control is CheckBox checkBox && checkBox.Checked)
                        {
                            cursos[indice] = checkBox.Text;
                            indice++;
                        }
                    }

                    ingresante = new Ingresante(txtNombre.Text, txtDireccion.Text, (int)nudEdad.Value, lstPaises.SelectedItem.ToString(),
                        genero, cursos);
                    MessageBox.Show(ingresante.Mostrar());
                }
            }
        }
    }
}