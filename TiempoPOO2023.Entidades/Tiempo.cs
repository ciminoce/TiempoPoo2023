using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiempoPOO2023.Entidades
{
    public class Tiempo
    {
        private int hora;
        private int minutos;
        private int segundos;

        public Tiempo(int hora, int minutos, int segundos)
        {
            this.hora = hora;
            this.minutos = minutos;
            this.segundos = segundos;
        }
        public Tiempo(int hora, int minutos):this(hora, minutos,59) { }

        public Tiempo(int hora) : this(hora, 59) { }

        public string MostarTiempo()
        {
            return $"{hora.ToString().PadLeft(2,'0')}:" +
                $"{minutos.ToString().PadLeft(2, '0')}:" +
                $"{segundos.ToString().PadLeft(2, '0')}";
        }
        public static bool operator ==(Tiempo t1, Tiempo t2)
        {
            return t1.hora==t2.hora 
                && t1.minutos==t2.minutos 
                && t1.segundos==t2.segundos; 
        }
        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tiempo v)
        {
            return (v.hora * 60 + v.minutos) * 60 + v.segundos;
        }

        public static explicit operator Tiempo(string v)
        {
            var array = v.Split(':');
            var hora = int.Parse(array[0]);
            var minutos = int.Parse(array[1]);
            var segundos = int.Parse(array[2]);
            return new Tiempo(hora, minutos, segundos);
        }

        public static Tiempo operator +(Tiempo t1, Tiempo t2)
        {
            int segundosTotales = t1.hora * 3600 + t1.minutos * 60 + t1.segundos
                        + t2.hora * 3600 + t2.minutos * 60 + t2.segundos;

            int horas = segundosTotales / 3600;
            int minutos = (segundosTotales % 3600) / 60;
            int segundos = (segundosTotales % 3600) % 60;

            return new Tiempo(horas, minutos, segundos);
        }
    }
}
