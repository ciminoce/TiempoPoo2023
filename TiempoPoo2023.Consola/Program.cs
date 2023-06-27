using System;
using TiempoPOO2023.Entidades;

namespace TiempoPoo2023.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Tiempo(10, 10, 12);
            var t2 = new Tiempo(7, 16);
            var t3 = new Tiempo(8);
            Console.WriteLine(t1.MostarTiempo());
            Console.WriteLine(t2.MostarTiempo());
            Console.WriteLine(t3.MostarTiempo());

            var t4 = t1;
            var t5 = new Tiempo(10, 10, 12);
            Console.WriteLine(t4 == t1);
            Console.WriteLine(t5==t1);

            int segundos = t2;
            Console.WriteLine(segundos);

            Tiempo nuevoTiempo = (Tiempo)"17:59:27";
            Console.WriteLine(nuevoTiempo.MostarTiempo());

            Console.WriteLine((t1 + t2).MostarTiempo());

            Console.ReadLine();
        }
    }
}
