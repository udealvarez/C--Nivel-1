namespace Ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        //  EJERCICIO

        /*
            Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar
            por pantalla cuántos de esos números son primos.
        */

        int numero = 0, contador = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingresar un numero: ");
            numero = int.Parse(Console.ReadLine());
            bool esPrimo = true;

            for (int j = 2; j < numero; j++)
            {
                if (numero % j == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if(esPrimo)
                contador++;
        }

        Console.WriteLine("La cantidad de numeros primos es: " + contador);

    }
}
