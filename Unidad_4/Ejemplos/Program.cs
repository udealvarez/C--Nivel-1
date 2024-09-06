namespace Ejemplos;

class Program
{
    static void Main(string[] args)
    {
        // AND y OR..... NOT

        // AND [y] Operador: &&
        // OR [o] Operador: ||

        // variable OP variable OR variable OP variable

        int edad = 20;
        char inicial = 'j';

        if (edad > 20 && inicial == 'h')
            Console.WriteLine("21 OFF..");

        if (edad > 20 || inicial == 'j')
            Console.WriteLine("20 OFF..");

    }
}
