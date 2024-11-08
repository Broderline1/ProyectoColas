using System;
using System.Net.Http.Headers;
using System.Threading;

namespace ProyectoCola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int selMenu;
            int count = 0;
            Cola cola = new Cola(count);

            do
            {
                Console.Write("MENU Colas\r\n---------------------------------\r\n1.- Establecer Tamaño\r\n2.- Count\r\n3.- Insert\r\n4.- Extract\r\n5.- Imprimir \r\n6.- Salir\r\n_____________________\r\nSelecciónar Opción => ");
                selMenu = Convert.ToInt32(Console.ReadLine());

                switch(selMenu)    
                {
                    case 1:;
                        Console.WriteLine("Ingresa el tamaño de la pila");
                        count = Convert.ToInt32(Console.ReadLine());
                        cola.InsertarTamano(count);

                        Console.ReadLine();
                        Console.Clear();
                    break;

                    case 2:
                        int conteo = cola.Count();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Los valores insertados en la cola son: {conteo}");
                        Console.ResetColor();

                        Console.ReadLine();
                        Console.Clear();
                    break;

                    case 3:
                        Console.WriteLine("Inserta el valor de una cola");
                        int valCola = Convert.ToInt32(Console.ReadLine());
                        cola.Insert(valCola);

                        Console.ReadLine();
                        Console.Clear();
                    break;

                    case 4:
                        int valExtraido = cola.Extract();

                        Console.ReadLine();
                        Console.Clear();
                    break;

                    case 5:
                        cola.Print();

                        Console.ReadLine();
                        Console.Clear();
                    break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Saliendo...");
                        Console.ResetColor();
                        Console.ReadLine();
                    break;

                    default:

                        Console.WriteLine("El valor que ingresaste no existe en el menu");

                    break;
                }
            }
            while (selMenu != 6);
        }
    }
}