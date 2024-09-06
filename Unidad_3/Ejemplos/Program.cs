namespace Ejemplos;

class Program
{
    static void Main(string[] args)
    {
        // BLOQUE IF: Condicionales.

        // OP - Operadores Relacionales
        // > <      | mayor - menor
        // >= <=    | mayor o igual - menor o igual
        // == !+    | igual - distinto

        // El condicional esta formada por el siguiente formato
        // valor OP valor --> valor o variable

        int edad = 35;

        if (edad > 20) // --> IF ANIDADO
        {
            if (edad >= 30) // --> otro nivel 
            {
                Console.WriteLine("30 OFF");                
            }
            else
            {
                Console.WriteLine("21 OFF");
            }          
        }
        else
        {
            Console.WriteLine("10 OFF");
        }
        Console.WriteLine("FIN DEL PROGRAMA");

        // REFACTOR IF - solo cuando tiene una sola instruccion

        if (edad > 20) // --> IF ANIDADO
        {
            if (edad >= 30) // --> otro nivel             
                Console.WriteLine("30 OFF");             
            else
                Console.WriteLine("21 OFF");                     
        }
        else        
            Console.WriteLine("10 OFF");

        Console.WriteLine("FIN DEL PROGRAMA");

        // otra forma de REFACTOR IF

        if (edad > 30)
        {
            Console.WriteLine("30 OFF");
        }
        else if (edad > 20) // ( SINO SI ) --> Segundo nivel de condicionalidad
        {
            Console.WriteLine("21 OFF");                    
        }
        else if (edad == 18) 
        {
            Console.WriteLine("10 OFF");                    
        }
        else // ( SINO )
        {
           Console.WriteLine("5 OFF"); 
        }
        Console.WriteLine("FIN DEL PROGRAMA");

    }
}
