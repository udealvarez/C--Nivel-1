namespace Ejercicio_5;

class Program
{
    static void Main(string[] args)
    {
        // ENUNCIADO

        /*Hacer un programa para ingresar por teclado las tres notas de 
        exámenes de un alumno y luego calcule y emita por pantalla el 
        promedio final.*/

        float nota1, nota2, nota3, promedio;

        Console.WriteLine("Ingrese la primera nota: ");
        nota1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota: ");
        nota3 = float.Parse(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio del alumno es: " + promedio);

    }
}
