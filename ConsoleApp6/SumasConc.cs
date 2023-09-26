using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Schema;

namespace ConsoleApp6
{
    internal class SumasConc
    {
        private int total = int.MaxValue/2;
        public int cont = 0;
        private int[] o1,o2,r;

        public void CrearNumeros()
        {
            Random rand = new Random();

            o1 = new int[total];
            o2 = new int[total];
            r = new int[total];

            for(int i = 0; i < total;i++)
            {
                o1[i] = rand.Next();
                o2[i] = rand.Next();
            }
        }
        public void SumasSecuencial()
        {
            for (int i = 0; i < total; i++)
                r[i] = o1[i] + o2[i];
        }

        public void SumasConcurrentes()
        {
            Thread t = new Thread(Hilo);
            Thread t1 = new Thread(Hilo);

            t.Start();
            t1.Start();
        }

        public void Hilo()
        {
            int res;
            Random r = new Random();

            for (int i = 0; i < total / 2; i++)
                res = r.Next() + r.Next();

            cont++;
        }
    }
}

/*
public void ejecutaConc() 
{
    Thread hilo1 = new Thread(Hilo);
    Thread hilo2 = new Thread(Hilo);

    hilo1.Start();
    hilo2.Start();
}
public void Hilo()
{
    int res;
    Random r = new Random();

    for (int i = 0; i < total / 2; i++)
        res = r.Next() + r.Next();
    
    cont++;
}

Ese es de Hilos




public void ejecutaSuma()
{
    int res;
    Random r = new Random();
    for (int i = 0; i < total; i++)
        res = r.Next() + r.Next();
}

Y este es del Lunes
*/