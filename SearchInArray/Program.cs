using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SearchInArray
{
    internal class Program { 


        static void Main(string[] args)
        {
            int tamano=0;

            while(tamano==0)
            {

            // Pedimos al usuario el tamaño del array.
            Console.WriteLine("Dígame el tamaño del array:");
            try
            {
                tamano = int.Parse(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("--- Formato no válido. Ingrese un número ---");
       
            }
            }


            // Se crea el array con el tamaño indicado.
            float[] arrayNumeros = new float[tamano];

            AnadirNumerosArray(arrayNumeros);

            string entradaUsuario;


            // Le pedimos al usuario que escriba un número para encontrarlo y saldrá cuando el usuario
            // escriba "end".
            while (true)
            {
                Console.Write("Ingrese un número o escriba 'end' para parar: ");
                entradaUsuario = Console.ReadLine();
                if (entradaUsuario.ToLower() == "end")
                {
                    break;
                } 

                float buscarNumero = 0;
                try
                {
                buscarNumero = float.Parse(entradaUsuario);
            } catch (FormatException)
                {
                    Console.WriteLine("--- Ingrese un número o 'end' para terminar ---");
                    continue;
                }
                if (siExisteNumero(arrayNumeros, buscarNumero))
                {
                    Console.WriteLine("El número " + buscarNumero + " está en la lista");
                } else
                {
                    Console.WriteLine("El número " + buscarNumero + " no está en la lista");
                }
            }

    }

        static void AnadirNumerosArray(float[]numeros)
        {
            for (int i = 0;i<numeros.Length;i++)
            {
                try
                {
                    Console.WriteLine("Ingrese el número " + (i + 1) + ": ");
                    numeros[i] = float.Parse(Console.ReadLine());
                } catch (FormatException)
                {
                    Console.WriteLine("--- Formato no válido. Ingrese un número ---");
                    i--;
                    continue;
                }
            }
        }

        static bool siExisteNumero(float[] arrayNumeros, float buscarNumero)
        {
            for (int i = 0; i< arrayNumeros.Length;i++)
            {
                if (arrayNumeros[i] == buscarNumero)
                {
                    return true;
                }
            }
            return false;
        }


    }


}



