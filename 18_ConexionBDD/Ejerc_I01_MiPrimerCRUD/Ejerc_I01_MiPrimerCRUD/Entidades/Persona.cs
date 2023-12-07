namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        //public Persona()
        //{

        //}
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido)
            :this(nombre, apellido)
        {
            this.Id = id;
        }

        public int Id 
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
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
                this.apellido = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido}";
        }
    }
}