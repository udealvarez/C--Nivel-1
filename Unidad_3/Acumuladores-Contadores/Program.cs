namespace Acumuladores_Contadores;

class Program
{
    static void Main(string[] args)
    {
        // Acumuladores y contadores:

        int contador = 0, edad1 = 20, edad2 = 13, edad3 = 30;
        int acumulador = 0, promedio;

        // ++
        // --
        // +=

        if (edad1 > 18)
        {
            contador++;
            acumulador += edad1;
        }

        if (edad2 > 18)
        {
            contador++;
            acumulador += edad2;
        }

        if (edad3 > 18)
        {
            contador++;
            acumulador += edad3;
        }

        promedio = acumulador / contador;

        Console.Write("El promedio es: " + promedio);  

    }
}
