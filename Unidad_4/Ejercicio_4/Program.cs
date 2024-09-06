namespace Ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO 4

        /*
            Hacer un programa para ingresar tres números y emitir un cartel
            aclaratorio si la suma de los dos primeros es mayor al producto 
            del segundo con el tercero.
        */

        int numero1 = 0, numero2 = 0, numero3 =0;

        Console.WriteLine("Ingrese el primer numero : ");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero : ");
        numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer numero : ");
        numero3 = int.Parse(Console.ReadLine());

        if ((numero1 + numero2) > (numero2 * numero3))
            Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");
        else
            Console.WriteLine("No se cumple el enunciado");

    }
}
