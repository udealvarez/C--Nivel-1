namespace Ejemplo_FOR;

class Program
{
    static void Main(string[] args)
    {
        // CICLO FOR

        // EJEMPLO 1

        
        int n = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i + " Hola mundo");
            n++;           

        }
        Console.WriteLine("la cantidad de mensajes es de " + n);

        

        // EJEMPLO 2

        int m, promedio, suma = 0;        

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingresar un numero: ");
            m = int.Parse(Console.ReadLine());
            suma += m;
        }

        promedio = suma / 5;

        Console.WriteLine("El promedio de notas es: " + promedio);
    }
}
