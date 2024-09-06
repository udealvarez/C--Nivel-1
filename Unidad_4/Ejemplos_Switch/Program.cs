namespace Ejemplos_Switch;

class Program
{
    static void Main(string[] args)
    {
        // SWITCH

        char letra = 'a';

        switch (letra)
        {
            case'm':
                Console.WriteLine("Tu nombre empieza con M..");                
                break;
            case 'h':
                Console.WriteLine("Tu nombre empieza con H..");                
                break;
            case 'r':
                Console.WriteLine("Tu nombre empieza con R..");                
                break;
            default:
                Console.WriteLine("Tu nombre no coincide con ninguna letra");                
                break;
        }

    }
}
