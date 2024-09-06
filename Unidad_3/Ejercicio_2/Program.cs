namespace Ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // ENUNCIADO 

        /* 
            Hacer un programa para ingresar un número y luego se emita un cartel
            por pantalla “Positivo” si el número es mayor a cero,
            “Negativo” si el número es menor a cero
            o “Cero” si el número es igual a cero.
        */
        
        int numero = 0;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero == 0)        
            Console.WriteLine("El numero ingresado es 0");
        
        else if (numero > 0)        
            Console.WriteLine("El numero es POSITIVO");
        else        
            Console.WriteLine("El numero es NEGATIVO");

    }
}
