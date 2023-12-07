using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Formularios
{
    public partial class FrmListaSuper : Form
    {
        List<string> listaSupermercado;
        private static string rutaArchivo;

        static FrmListaSuper()
        {
            string rutaApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            const string nombreArchivo = "listaSupermercado.xml";
            FrmListaSuper.rutaArchivo = Path.Combine(rutaApplicationData, nombreArchivo);
        }
        public FrmListaSuper()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.listaSupermercado = new List<string>();
            
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            this.ConfigurarTooltips();
            this.CargarListaAlmacenada();
            this.RefrescarLista();
        }

        private void ConfigurarTooltips()
        {
            this.toolTipAgregar.SetToolTip(this.btnAgregar, "Agregar objeto");
            this.toolTipEliminar.SetToolTip(this.btnEliminar, "Eliminar objeto");
            this.toolTipModificar.SetToolTip(this.btnModificar, "Modificar objeto");
        }

        private void RefrescarLista()
        {
            this.lstObjetos.DataSource = null;
            this.lstObjetos.DataSource = this.listaSupermercado;
        }

        private void CargarListaAlmacenada()
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    try
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(this.listaSupermercado.GetType());
                        this.listaSupermercado = xmlSerializer.Deserialize(sr) as List<string>;
                    }
                    catch (Exception ex)
                    {
                        this.MostrarMensajeDeError(ex);
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", "", "Agregar");
            frmAltaModificacion.ShowDialog();

            if (frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                this.listaSupermercado.Add(frmAltaModificacion.Objeto);
                this.AlmacenarCambios();
                this.RefrescarLista();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = (string)lstObjetos.SelectedItem;

            if (objetoSeleccionado is not null)
            {
                this.listaSupermercado.Remove(objetoSeleccionado);
                this.AlmacenarCambios();
                this.RefrescarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = (string)lstObjetos.SelectedItem;

            if (objetoSeleccionado is not null)
            {
                FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Modificar objeto", objetoSeleccionado, "Modificar");
                frmAltaModificacion.ShowDialog();

                if (frmAltaModificacion.DialogResult == DialogResult.OK)
                {
                    int indice = this.listaSupermercado.IndexOf(objetoSeleccionado);
                    this.listaSupermercado[indice] = frmAltaModificacion.Objeto;
                    this.AlmacenarCambios();
                    this.RefrescarLista();                 
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                 
        }

        private void AlmacenarCambios()
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(this.listaSupermercado.GetType());
                    xmlSerializer.Serialize(streamWriter, this.listaSupermercado);
                }
                catch (Exception ex)
                {
                    MostrarMensajeDeError(ex);
                }
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
    }
}
