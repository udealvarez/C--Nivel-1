namespace Ejercicio_10;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO

        /*
            Hacer un programa que solicite 12 temperaturas y luego muestre
            Cuántas de ellas están por encima de los 30 grados.
        */

        int numero, contador = 0;

        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine("Ingresar la temperatura: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 30)
                contador++;           
        }

        Console.WriteLine("La cantidad de TEMPERATURAS mayores a 30 es: " + contador);  
    }
}
