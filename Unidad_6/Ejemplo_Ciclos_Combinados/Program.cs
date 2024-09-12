namespace Ejemplo_Ciclos_Combinados;

class Program
{
    static void Main(string[] args)
    {
        // CICLO COMBINADOS

        // FOR CON FOR

        int promedio, acumulador = 0, numero, contador = 0;

        for (int i = 0; i < 10; i++)
        {
            acumulador = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese la edad: ");
                numero = int.Parse(Console.ReadLine());
                acumulador += numero ;
            }

            promedio = acumulador / 5;
            Console.WriteLine("El promedio es: " + promedio);
        }


        // FOR CON WHILE

        for (int z = 0; z < 10; z++)
        {
            Console.WriteLine("Ingrese la edad: ");
            numero = int.Parse(Console.ReadLine());

            acumulador = 0;
            contador = 0;

            while (numero != 0)
            {
                acumulador += numero;
                contador++;

                Console.WriteLine("Ingrese la edad: ");
                numero = int.Parse(Console.ReadLine());
            }
            promedio = acumulador / contador;
            Console.WriteLine("El promedio es: " + promedio);
        }


        // WHILE CON FOR


        Console.WriteLine("Ingrese 1 para comenzar a procesar o 0 para terminar: ");
        numero = int.Parse(Console.ReadLine());

        while (numero != 0)
        {
            acumulador = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese la edad: ");
                numero = int.Parse(Console.ReadLine());
                acumulador += numero ;
            }

            promedio = acumulador / 5;
            Console.WriteLine("El promedio es: " + promedio);

            Console.WriteLine("Ingrese 1 para continuar o 0 para terminar: ");
            numero = int.Parse(Console.ReadLine());
        }
        

        // WHILE CON WHILE

        while (numero > 0)
        {
            Console.WriteLine("Ingrese la edad: ");
            numero = int.Parse(Console.ReadLine());

            acumulador = 0;
            contador = 0;

            while (numero != 0)
            {
                acumulador += numero;
                contador++;

                Console.WriteLine("Ingrese la edad: ");
                numero = int.Parse(Console.ReadLine());
            }
            promedio = acumulador / contador;
            Console.WriteLine("El promedio es: " + promedio);

            Console.WriteLine("Ingrese la edad para continuar o un negativo para cortar: ");
            numero = int.Parse(Console.ReadLine());
        }
            
        
    }
}
