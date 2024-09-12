namespace Ejercicio_9;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO

        /*
            Hacer un programa que solicite el ingreso de 5 números y
            luego muestre la suma de los números negativos ingresados.
        */

        int numero, negativos = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingresar un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)            
                negativos = negativos + numero;            
        }

        Console.WriteLine("La suma de los numeros negativos es: " + negativos);
    }
}
