namespace ClassBoligrafo
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta() 
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta > 0)
            {
                if ((this.tinta + tinta) > Boligrafo.cantidadTintaMaxima)
                {
                    this.tinta = Boligrafo.cantidadTintaMaxima;
                }
                else
                {
                    this.tinta += tinta;
                }
            }

            else if (tinta < 0)
            {
                if (this.tinta > 0)
                {
                    if ((this.tinta + tinta) < 0)
                    {
                        this.tinta = 0;
                    }
                    else
                    {
                        this.tinta += tinta;
                    }
                }
            }
        }

        public void Recargar()
        {
            this.SetTinta(Boligrafo.cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            string cadenaAux = string.Empty;
            bool returAux = false;
            short contador = 0;

            if (this.tinta == 0)
            {
                dibujo = "No se puede pintar";
            }
            else
            {
                while (gasto > 0 && (this.tinta + contador) > 0)
                {
                    cadenaAux += "*";
                    contador--;
                    gasto--;   
                }
                dibujo = cadenaAux;
                returAux = true;
                this.SetTinta(contador);
            }
            return returAux;
        }

    }
}