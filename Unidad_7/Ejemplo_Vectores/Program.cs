using System.Formats.Asn1;

namespace Ejemplo_Vectores;

class Program
{
    static void Main(string[] args)
    {
        // VECTORES - ARRAY  - ARREGLO

        int num;
        int[] numeros = new int[10]; // asi se escribe

        //   0 1 2 3 4 5  6  7 8  9
        //  [7][][][][][][1][][][32450]  --> elementos del vector

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese la nota..");
            num = int.Parse(Console.ReadLine());

            numeros[i] = num;
        }

        int acumulador = 0;

        for (int i = 0; i < 10; i++)
        {
            acumulador += numeros[i];
            Console.WriteLine("el valor es " + numeros[i]);
        }

        int promedio = acumulador / 10;

        Console.WriteLine("el promedio es " + promedio);

    }
}
