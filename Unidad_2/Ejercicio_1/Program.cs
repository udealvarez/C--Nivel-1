namespace Ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        // ENUNCIADO
        // Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
        

            float resultado, num1, num2;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingregse el segundo numero: ");
            num2 = float.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("El resultado de la suma es: " + resultado);


    }
}
