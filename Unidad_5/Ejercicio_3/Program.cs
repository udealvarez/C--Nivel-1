namespace Ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO

        /*
            Hacer un programa que solicite 20 edades y luego calcule el promedio
            de edad de aquellas personas mayores a 18 años.
        */

        double edad = 0, promedio = 0, contador = 0, acumulador = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("Ingrese la edad " + i + ": ");
            edad = double.Parse(Console.ReadLine());

            if (edad > 18)
            {
                acumulador += edad;
                contador++;               
            }
        }

        promedio = acumulador / contador;
        Console.WriteLine("El promedio de las edades de mayores de 18 es: " + promedio);
    }
}
