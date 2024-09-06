namespace Ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        // ENUNCIADO

        /*
        Hacer un programa para ingresar un número y luego se emita por pantalla un
        cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
        */

        int numero = 0;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero == 10 || numero > 10)
        {   
            if (numero > 10)
            {
                Console.WriteLine("El numero ingresado es MAYOR a 10");
            }else
            {
                Console.WriteLine("El numero ingresado es 10");
            }
            
        }else
        {
            Console.WriteLine("El numero ingresado es MENOR a 10");
        }

    }
}
