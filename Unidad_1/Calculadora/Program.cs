﻿namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
            //paso 0
            // tipo de dato: int, float, char, bool
            int n1, n2, resultado;            
            
            // paso 1: pedir valores
            Console.WriteLine("Ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());                

            
            // paso 2: realizar calculo
            resultado =  n1 + n2;

            // paso 3: emitir resultado
            Console.WriteLine("El resultado es: " + resultado);
    }
}
