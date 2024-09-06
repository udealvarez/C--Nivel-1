using System.Data;

namespace Ejemplo_WHILE;

class Program
{
    static void Main(string[] args)
    {
        int n, contador = 0;        

        Console.WriteLine("Ingresar un numero: ");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            contador++;
            Console.WriteLine("Ingresar un numero: ");
            n = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Ingresaste con: " + contador + " numeros");

        // EJEMPLO 2 - simulo un CICLO FOR

        while (contador < 10)
        {
            contador++;
            Console.WriteLine(contador);
        }

    }
}
