using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizarNombreDelegado(string nombre);
        private ActualizarNombreDelegado actualizarNombreDelegado;

        public FrmTestDelegados(ActualizarNombreDelegado actualizarNombreDelegado)
        {
            InitializeComponent();
            this.actualizarNombreDelegado = actualizarNombreDelegado;
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.actualizarNombreDelegado is not null)
            {
                this.actualizarNombreDelegado.Invoke(this.txtNombre.Text);
            }        
        }
    }
}
