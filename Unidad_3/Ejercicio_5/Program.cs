namespace Ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO

        /*
            Hacer un programa para ingresar cuatro números y 
            luego mostrar por pantalla cuáles son mayores a 100.
        */
        
        int a, b, c, d;

        Console.WriteLine("Ingresar el primer numero: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar el segundo numero: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar el tercer numero: ");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar el cuarto numero: ");
        d = int.Parse(Console.ReadLine());

        if (a > 100)        
            Console.WriteLine(a + " es mayor a 100");
        
        if (b > 100)        
            Console.WriteLine(b + " es mayor a 100");
        
        if (c > 100)        
            Console.WriteLine(c + " es mayor a 100");
        
        if (d > 100)        
            Console.WriteLine(d + " es mayor a 100");
        
    }
}
