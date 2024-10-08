namespace Ejemplo_Vector2;

class Program
{
    static void Main(string[] args)
    {
        
        // VECTOR DOUBLE

        double [] muestraMatutina = new double[31];
        double [] muestraVespertina = new double[31];
        double [] muestraNocturna = new double[31];

        // cruce
        // registro matutino

        int dia;
        double temperatura;
        Console.WriteLine("Ingrese el registro matutino: ");


        for (int i = 0; i < 31; i++)
        {
            Console.WriteLine("Ingrese el dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese temperatura registrada: ");
            temperatura = double.Parse(Console.ReadLine());    

            muestraMatutina[dia-1] = temperatura;
            // esta estrategia te sirve cuando tenes numeros consecutivos
        }

        // LEER VECTORES
        double acumulador = 0;
        for (int i = 0; i < 31; i++)
        {
            acumulador += muestraMatutina[i];
        }

        double promedio = acumulador / 31;

        Console.WriteLine("El promedio de las temperaturas es " + promedio);


    }
}
