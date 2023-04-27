using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    internal class Casino
    {
        public string [] MaquinaCasino()
        {
            Random r = new Random();
            string[] maquina = new string[6];
            maquina[0] = "♣";
            maquina[1] = "♦";
            maquina[2] = "☺";
            maquina[3] = "☼";
            maquina[4] = "■";
            maquina[5] = "◕";
            string[] resultado = new string[4];

            for (int i = 0; i < 4; i++)
            {
                resultado[i] = maquina[r.Next(0, 5)];
                
            }
            return resultado;
        }
        public double Probabilidades(double dinero)
        {
           string[] datos = new string[4]; 
           datos = MaquinaCasino();
            if (datos[0] == datos[1] && datos[0] == datos[2] && datos[0] == datos[3] && datos[0] == "♣")
            {
                dinero += dinero * 8;
            }
            if(datos[0] == datos[1] && datos[0] == datos[2] && datos[0] == datos[3] && datos[0] == "♦")
            {
                dinero += dinero * 10;
            }
            if (datos[0] == "☺" || datos[1] == "☺" || datos[2] == "☺" || datos[3] == "☺")
            {
                for (int j = 0; j < 4; j++)
                {
                    if (datos[j] == "☺")
                    {
                        dinero += dinero * 1; 
                    }
                }
            }
            if (datos[0] == "☼" || datos[1] == "☼" || datos[2] == "☼" || datos[3] == "☼")
            {
                for (int l = 0; l < 4; l++)
                {
                    if (datos[l] == "☼")
                    {
                        dinero += dinero * 0.25;
                    }
                }
            }
            if (datos[0] == "◕" || datos[1] == "◕" || datos[2] == "◕" || datos[3] == "◕")
            {
                for (int a = 0; a < 4; a++)
                {
                    if (datos[a] == "◕")
                    {
                        dinero = 0;
                    }
                }
            }
            else
            {
                dinero = dinero; 
            }

                return dinero;
        }

        static void Main(string[] args)
        {
            Casino mostrar = new Casino();
            double dinero = 0;
            Console.WriteLine("Ingrese monto");
            dinero = Convert.ToDouble(Console.ReadLine());
            string[] si = mostrar.MaquinaCasino();
            for (int i = 0;i < 4; i++)
            {
                    Console.Write(si[i]+ "-");
                
            }
            Console.WriteLine("\nUsted se lleva: "+ mostrar.Probabilidades(dinero));
            Console.ReadKey();
        }
    }
}
