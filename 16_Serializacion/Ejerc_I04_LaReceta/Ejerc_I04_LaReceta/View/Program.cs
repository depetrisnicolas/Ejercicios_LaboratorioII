using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Ricardo", "Perez");
            Console.WriteLine(persona1);
            Console.WriteLine("***********************************");

            try
            {
                Persona.GuardarXml(persona1);
                Persona persona2 = Persona.LeerXml();
                Console.WriteLine(persona2.ToString());
                Console.WriteLine("***********************************");
                Persona.GuardarJson(persona1);
                Persona persona3 = Persona.LeerJson();
                Console.WriteLine(persona3.ToString());
                
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }

    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido= value;   
            }
        }

        public static void GuardarXml(Persona unaPersona)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "Ejercicios Serializacion");
            string archivoXml = "Prueba.xml";
            string rutaCompleta = Path.Combine(path, archivoXml);

            using (StreamWriter streamWriter = new StreamWriter(rutaCompleta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                xmlSerializer.Serialize(streamWriter, unaPersona);
            }
        }

        public static Persona LeerXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "Ejercicios Serializacion");
            string archivoXml = "Prueba.xml";
            string rutaCompleta = Path.Combine(path, archivoXml);

            using (StreamReader streamReader = new StreamReader(rutaCompleta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                Persona persona = xmlSerializer.Deserialize(streamReader) as Persona;

                return persona;
            }
        }

        public static void GuardarJson(Persona persona)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "Ejercicios Serializacion");
            string archivoJson = "Prueba2.json";
            string rutaCompleta = Path.Combine(path, archivoJson);

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            
            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                string json = JsonSerializer.Serialize(persona, options);
                sw.WriteLine(json);
            }
        }

        public static Persona LeerJson()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "Ejercicios Serializacion");
            string archivoJson = "Prueba2.json";
            string rutaCompleta = Path.Combine(path, archivoJson);

            using (StreamReader sr = new StreamReader(rutaCompleta))
            {
                string jsonString = sr.ReadToEnd();
                Persona persona = JsonSerializer.Deserialize<Persona>(jsonString);
                return persona;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {this.Nombre}");
            stringBuilder.AppendLine($"Apellido: {this.Apellido}");

            return stringBuilder.ToString();
        }

    }
}