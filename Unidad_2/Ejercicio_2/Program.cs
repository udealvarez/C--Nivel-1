namespace Ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // ENUNCIADO
        // Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
        
            float num, resultado;

            Console.WriteLine("Ingrese un numero: ");
            num = float.Parse(Console.ReadLine());

            resultado = num * num * num;

            Console.WriteLine("El cubo del numero ingresado es: " + resultado);

    }
}
