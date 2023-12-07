using System.Text;

namespace FormContador
{
    public partial class ContadorPalabras : Form
    {
        private Dictionary<string, int> diccionario;
        private List<string> listaDePalabras;

        public ContadorPalabras()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            listaDePalabras = new List<string>();
        }

        public void ContarPalabras(string texto)
        {
            char[] separacion = new char[] { ' ', ',', '.', ':', ';', '\t', '\n' };
            listaDePalabras.AddRange(texto.Split(separacion, StringSplitOptions.RemoveEmptyEntries));

            foreach (string palabra in listaDePalabras)
            {
                if (!diccionario.ContainsKey(palabra) && palabra != " ")
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra] += 1;
                }
            }
        }

        private string Mostrar(Dictionary<string, int> diccionario)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Contador de palabras: \n");
            Dictionary<string, int> diccionarioOrdenado = new Dictionary<string, int>(diccionario.OrderByDescending
                (x => x.Value));

            int contador = 0;
            foreach (KeyValuePair<string, int> par in diccionarioOrdenado)
            {
                if (contador < 3)
                {
                    sb.AppendLine($"{par.Key} : {par.Value}");
                    contador++;
                }
            }
            return sb.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ContarPalabras(txtPalabras.Text);
            DialogResult result = MessageBox.Show(Mostrar(diccionario));
            txtPalabras.Text = "";
            diccionario.Clear();
            listaDePalabras.Clear();

        }

        public static int FuncionCriterio(int a, int b)
        {
            return b - a;
        }
    }
}