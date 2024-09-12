namespace Ejercicio_8;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO

        /*
            Hacer un programa que solicite 10 números y 
            luego emita cuántos de ellos son números pares.
        */

        int numero, contador = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                contador++;
        }
        Console.WriteLine("la cantidad de numeros pares es: " + contador);
    }
}
