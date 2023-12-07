using Entidades;
using Entidades.excepciones;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            { 

                if (string.IsNullOrWhiteSpace(txtKm.Text) || string.IsNullOrWhiteSpace(txtLitros.Text))
                {
                    throw new ParametrosVaciosException("Ambos campos deben ser completados");
                }

                int km = int.Parse(txtKm.Text);
                int litros = int.Parse(txtLitros.Text);

                double resultado = Calculador.Calcular(km, litros);

                richTextBox1.Text = $"Consumo: {resultado:F2} km/l";
            }

            catch (FormatException)
            {
                MessageBox.Show("Los valores ingresados no son números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ParametrosVaciosException ex)
            {   
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}