using CentralitaHerencia.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costo;


        public Local()
            :base(0, string.Empty, string.Empty)
        {

        }
        public Local(Llamada llamada, float costo)
            :this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {           
        }

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion, destino, origen)
        {
            this.costo = costo; 
        }

        public string RutaDeArchivos
        {
            get
            {
                return @"C:\Users\nico_\Desktop\Ejercicios Serializacion";
            }
            set
            {
                this.RutaDeArchivos = value;
            }
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public bool Guardar()
        {
            string archivoXml = "MetodoGuardarXMLLocal.xml";
            string rutaCompleta = Path.Combine(this.RutaDeArchivos, archivoXml);

            using (StreamWriter streamWriter = new StreamWriter(rutaCompleta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Local));

                xmlSerializer.Serialize(streamWriter, this);
                return true;
            }
        }

        public bool GuardarJson()
        {
            string archivoJson = "MetodoGuardarJSONLocal.json";
            string rutaCompleta = Path.Combine(this.RutaDeArchivos, archivoJson);

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                string json = JsonSerializer.Serialize(this, options);
                sw.WriteLine(json);
                return true;
            }
        }

        public Local Leer()
        {
            try
            {
                string archivoXml = "MetodoGuardarLocal.xml";
                string rutaCompleta = Path.Combine(this.RutaDeArchivos, archivoXml);

                using (StreamReader streamReader = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Local));
                    var objetoDeserializado = xmlSerializer.Deserialize(streamReader);

                    if (objetoDeserializado is Local llamadaLocal)
                    {
                        return llamadaLocal;
                    }
                    else
                    {
                        throw new InvalidCastException("El objeto deserializado no es del tipo Local");
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al leer y deserializar el archivo.
                throw new Exception($"Error al leer el archivo XML: {ex.Message}");
            }
        }

        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo llamada: {this.CostoLlamada}");

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
