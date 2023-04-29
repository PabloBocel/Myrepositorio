using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ts13_PABM_1109623
{
    internal class Persona
    {
        private string Nombre;
        private string Apellido;
        private int Edad;
        private double Altura;
        public Persona() 
        {
            

            Console.WriteLine("Ingrese un Nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese un Apellido");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Edad");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Altura");
            Altura = Convert.ToDouble(Console.ReadLine());
             
        }
        public void NombreCompleto()
        {
            Console.WriteLine("Nombre: " +Nombre);
            Console.WriteLine("Apellido: "+ Apellido);
            Console.WriteLine("Edad: " + Edad + "años");
            Console.WriteLine("Altura: " + Altura + "cm");
        }


        static void Main(string[] args)
        {
           
            string menu = "";
            while (!menu.Equals("3"))
            {
                Console.WriteLine("Trabajo supervisado semana 13_PABM_1109623");
                Console.WriteLine("Ingrese una opción del menú");
                Console.WriteLine("1. Altura de una persona"+"\n2. Tabla de multiplicación"+"\n3. Salir");
                int mum = Convert.ToInt32(Console.ReadLine());
                switch (mum)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Trabajo supervisado semana 13_PABM_1109623");
                        Console.WriteLine("Altura de una persona\n");
                        Persona met = new Persona();
                        met.NombreCompleto();
                            
                            
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Trabajo supervisado semana 13_PABM_1109623");
                        Console.WriteLine("Tabla de multiplicar\n");
                        Console.Write("Ingrese el tamaño de la matriz: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el tamaño de la matriz: ");
                        int x = int.Parse(Console.ReadLine());

                        // Crear la matriz y rellenarla con la tabla de multiplicación
                        int[,] matriz = new int[n, x];
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= x; j++)
                            {
                                matriz[i - 1, j - 1] = i * j;
                            }
                        }

                        // Imprimir la matriz
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                Console.Write(matriz[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        menu = "3";
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción del menú");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
