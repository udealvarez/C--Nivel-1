namespace Ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        // ENUNCIADO
        
        /* Hacer un programa que permita ingresar los kilómetros existentes
        entre dos ciudades y la velocidad promedio de un vehículo. 
        Calcular y emitir por pantalla el tiempo aproximado que demandará 
        llegar de un punto a otro teniendo en cuenta los datos ingresados. */

        float tiempo, distancia, velocidad;

        Console.WriteLine("Ingrese los kilometros entre las 2 ciudades: ");
        distancia = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la velocidad promedio de un vehiculo: ");
        velocidad = float.Parse(Console.ReadLine());

        tiempo =  distancia / velocidad;

        Console.WriteLine("El tiempo aproximado para llegar de un punto a otro es: " + tiempo + " horas"); 

    }
}
