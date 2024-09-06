namespace Ejemplo_DO_WHILE;

class Program
{
    static void Main(string[] args)
    {
        // DO WHILE

        int n, contador = 0;        
        
        do
        {
            Console.WriteLine("Ingresar un numero: ");
            n = int.Parse(Console.ReadLine()); 
            contador++;

        } while (n != 0);

        Console.WriteLine("Ingresaste " + contador + " numeros");

    }
}
