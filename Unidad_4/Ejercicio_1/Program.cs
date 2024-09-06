namespace Ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO 1

        /*
            Hacer un programa que solicite el ingreso de dos números y luego calcular:

            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente.
        */

        double numero1 = 0, numero2 = 0, resultado = 0;

        Console.WriteLine("Ingrese el primer numero: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        numero2 = double.Parse(Console.ReadLine());

        if (numero1 > numero2)        
            resultado = numero1 - numero2;
        else if(numero1 == numero2)
            resultado = numero1 + numero2;
        else
            resultado = numero1 * numero2;

        Console.WriteLine("El resultado es: " + resultado);

    }
}
