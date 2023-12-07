using CentralitaHerencia.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial()
            :base(0, string.Empty, string.Empty)
        {

        }
        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
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
            string archivoXml = "MetodoGuardarXMLProvincial.xml";
            string rutaCompleta = Path.Combine(this.RutaDeArchivos, archivoXml);

            using (StreamWriter streamWriter = new StreamWriter(rutaCompleta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Provincial));

                xmlSerializer.Serialize(streamWriter, this);
                return true;
            }
        }

        public bool GuardarJson()
        {
            string archivoJson = "MetodoGuardarJSONProvincial.json";
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

        public Provincial Leer()
        {
            try
            {
                string archivoXml = "MetodoGuardarLocal.xml";
                string rutaCompleta = Path.Combine(this.RutaDeArchivos, archivoXml);

                using (StreamReader streamReader = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Provincial));
                    var objetoDeserializado = xmlSerializer.Deserialize(streamReader);

                    if (objetoDeserializado is Provincial llamadaProvincial)
                    {
                        return llamadaProvincial;
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
            float costo;

            switch (this.franjaHoraria) 
            {
                case Franja.Franja_1:
                    costo = base.Duracion * (float)0.99;
                    break;

                case Franja.Franja_2:
                    costo = base.Duracion * (float)1.25;
                    break;

                default:
                    costo = base.Duracion * (float)0.66;
                    break;
            }

            return costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}"); 
            sb.AppendLine($"Costo llamada: {this.CostoLlamada}");

            return sb.ToString();   
        }

        public override bool Equals(object? obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
