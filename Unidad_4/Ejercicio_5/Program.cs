namespace Ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO

        /*
            Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla
            si los mismos se encuentran ordenados de forma decreciente .
        */

        int numero1 = 0, numero2 = 0, numero3 = 0, numero4 = 0;

        Console.WriteLine("Ingrese el primer numero: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer numero: ");
        numero3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el cuarto numero: ");
        numero4 = int.Parse(Console.ReadLine());

        if (numero1 > numero2 && numero2 > numero3 && numero3 > numero4)
            Console.WriteLine("Los numeros estan ordenados de forma decreciente");
        else
            Console.WriteLine("Los numeros no estan ordenados de forma decreciente");

    }
}
