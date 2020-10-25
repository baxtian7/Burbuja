using System;

namespace Burbuja
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Leemos los datos de entrada y los almacenamos en un arreglos
            //string[] lista = Console.ReadLine().Split();
            string[] lista = new string[1000];
            Random rnd = new Random();

            for (int i = 1000 - 1; i >= 0; i--)
            {
                lista[i] = rnd.Next(1, 100).ToString();
            }

            foreach (string i in lista)
            {
                Console.Write("{0} ", i);
            }

            Console.Write("{0} ", "---------------------------------------------------------------------------------");
            //Iteramos, enviando el mayor al final en cada iteración
            Console.WriteLine("----------Tiempo:" + DateTime.Now.Millisecond);

            for (int i = 0; i <= lista.Length - 1; i++)
            {
                for (int j = 0; j < lista.Length - i - 1; j++)
                {
                    if (int.Parse(lista[j]) > int.Parse(lista[j + 1]))
                    {
                        string tem = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = tem;
                    }
                }
            }

            //Mostramos como quedo ordenado el arreglo
            foreach (string i in lista)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("----------Tiempo:" + DateTime.Now.Millisecond);


            Console.ReadLine();
        }
    }
}