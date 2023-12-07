using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using static System.Windows.Forms.Design.AxImporter;

namespace Formulario
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;


        static FrmCartelera()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            FrmCartelera.rutaConfiguracion = Path.Combine(appDataFolder, "configuracion.json");
        }


        public FrmCartelera()
        {
            InitializeComponent();
        }


        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            this.lblTitulo.Text = this.txtTitulo.Text;
        }


        private void txtMensaje_TextChanged(object sender, EventArgs e)
        {
            this.lblMensaje.Text = this.rtxtMensaje.Text;
        }


        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            this.pnlCartel.BackColor = this.ElegirColor(this.pnlCartel.BackColor);
        }


        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            this.ImportarConfig(FrmCartelera.rutaConfiguracion);
        }


        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            this.lblTitulo.ForeColor = this.ElegirColor(this.lblTitulo.ForeColor);
        }


        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            this.lblMensaje.ForeColor = this.ElegirColor(this.lblMensaje.ForeColor);
        }


        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files(*.json)|*.json";
            openFileDialog.ShowDialog();
            ImportarConfig(openFileDialog.FileName);
        }


        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la configuración?",
                "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                EliminarConfiguracion();
            }
        }


        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            this.GuardarConfig();
        }


        private void GuardarConfig()
        {
            try
            {
                Texto titulo = new Texto(this.lblTitulo.Text, this.lblTitulo.ForeColor.ToArgb());
                Texto mensaje = new Texto(this.lblMensaje.Text, this.lblMensaje.ForeColor.ToArgb());
                Cartel cartel = new Cartel(this.pnlCartel.BackColor.ToArgb(), titulo, mensaje);

                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                using (StreamWriter sw = new StreamWriter(FrmCartelera.rutaConfiguracion))
                {
                    string json = JsonSerializer.Serialize(cartel, opciones);
                    sw.WriteLine(json);
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }

        private Color ElegirColor(Color colorActual)
        {
            this.colorDialog.Color = colorActual;
            this.colorDialog.ShowDialog();
            return this.colorDialog.Color;
        }


        private void ImportarConfig(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string jsonString = File.ReadAllText(path);
                    Cartel cartel = JsonSerializer.Deserialize<Cartel>(jsonString);

                    this.pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    this.txtTitulo.Text = cartel.Titulo.Contenido;
                    this.lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    this.rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    this.lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                }
            }

            catch (JsonException)
            {
                MessageBox.Show("El archivo de configuración no se encuentra en el formato correcto.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }


        private void MostrarMensajeDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(ex.Message);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void EliminarConfiguracion()
        {
            try
            {
                if (File.Exists(FrmCartelera.rutaConfiguracion))
                {
                    File.Delete(FrmCartelera.rutaConfiguracion);
                }
                this.txtTitulo.Text = "Título";
                this.lblTitulo.ForeColor = Control.DefaultForeColor;

                this.rtxtMensaje.Text = "Mensaje";
                this.lblMensaje.ForeColor = Control.DefaultForeColor;

                this.pnlCartel.BackColor = Control.DefaultBackColor;
            }
            catch (Exception ex) 
            {
                this.MostrarMensajeDeError(ex);
            }
        }
    }
}