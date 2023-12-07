namespace Entidades
{
    public enum EEstaciones { Verano = 12, Otonio = 3, Invierno = 7, Primavera = 9 };

    public static class MetodoExtension
    {
        public static string ObtenerPlacaCronicaAle(this DateTime fecha, EEstaciones estacion)
        {
            int anio = 2023;
            int mes = (int)estacion;
            if (fecha.Month > mes)
            {
                anio = 2024;
            }

            DateTime fechaSegunEstacion = new DateTime(anio, (int)estacion, 21);
            TimeSpan lapsoDeTiempo = fechaSegunEstacion - fecha;

            return $"Falta {lapsoDeTiempo.TotalDays.ToString("0")} para el {estacion.ToString()}";
        }

        public static string ObtenerPlacaCronicaLucas(this DateTime fecha, EEstaciones estacion)
        {
            int diaFecha = fecha.DayOfYear;
            int diasDelAnio = new DateTime(fecha.Year, (int)estacion, 21).DayOfYear;

            if (diaFecha > diasDelAnio)
            {
                diasDelAnio += 365;
            }

            return $"Faltan {diasDelAnio - diaFecha} para el {Enum.GetName(estacion)}";
        }

    }
}