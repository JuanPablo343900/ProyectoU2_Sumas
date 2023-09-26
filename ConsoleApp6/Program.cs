using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumasConc sumas = new SumasConc();

            sumas.CrearNumeros();
            DateTime inicio = DateTime.Now;
            //18
            sumas.SumasSecuencial(); //50ms
            //sumas.SumasSecuencial(); //180ms
            //sumas.SumasConcurrentes();
            //while (sumas.cont != 2) ;

            DateTime fin = DateTime.Now;

            TimeSpan total = fin - inicio;
            Console.WriteLine("Total: " + total.Milliseconds);

            Console.ReadKey();
        }
    }
}
