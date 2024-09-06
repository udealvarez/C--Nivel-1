namespace Ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO 5

        /*
            Hacer un programa que solicite 20 números y luego emitir por pantalla
            el máximo de los números pares y el mínimo de los números impares.
        */

        int num = 0, maxPositivo = int.MinValue, minImpar = int.MaxValue;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingresar el numero " + i + ": ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                if (num > maxPositivo)                
                    maxPositivo = num;                               
            }
            else
            {
                if (num < minImpar)
                    minImpar = num;   
            } 
        }

        Console.WriteLine("El maximo de los numeros pares es: " + maxPositivo);
        Console.WriteLine("El minimo de los numeros impares es: " + minImpar);





        


    }
}
