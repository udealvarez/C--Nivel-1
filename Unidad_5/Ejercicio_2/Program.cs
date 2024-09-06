namespace Ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO 2

        /*
            Hacer un programa que solicite el ingreso de 10 números
            y que muestre el mayor de ellos por pantalla. 
            Solo se debe emitir UN valor por pantalla.
        */

        int n = 0, numMayor = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Ingrese el numero " + i + ": ");
            n = int.Parse(Console.ReadLine());

            if (n > numMayor)            
                numMayor = n;            
        }

        Console.WriteLine("El numero mayor es " + numMayor);
    }
}
