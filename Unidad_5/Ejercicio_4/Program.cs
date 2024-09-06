namespace Ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO 4

        /*
            Hacer un programa que solicite UN número y luego calcule y emita
            un cartel aclaratorio si el mismo es primo o no es primo.  
            Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
        */

        int n = 0, contador = 0;

        Console.WriteLine("Ingrese un numero: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)            
                contador++;              
        }

        if (contador == 2)
            Console.WriteLine("Es primo");
        else
            Console.WriteLine("NO ES PRIMO");
    }
}
