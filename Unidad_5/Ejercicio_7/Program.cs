namespace Ejercicio_7;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO

        /*
            Hacer un programa que solicite 15 números y 
            calcule cuántos de ellos son mayores a 50.
        */

        double numero, contador = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.WriteLine("Ingresar el " + i + ": ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 50)
                contador++;           
        }

        Console.WriteLine("La cantidad de numero mayores a 50 es: " + contador);  
    }
}
