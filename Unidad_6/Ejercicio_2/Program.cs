namespace Ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO

        /*
            Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
            Se pide determinar e informar:

            - El número de grupo con mayor porcentaje Impares de números impares
                respecto al total de números que forman el grupo.
            - Informar cuántos grupos están formados por todos números
                ordenados de mayor a menor.
        */

            int numero, contador, imapres, maximoImpar = 0, min, conOrdenados = 0;
            double porcentajeImpares, porcetajePar = -1;
            bool banderaOrdenados;
                        

            for (int x = 0; x < 5; x++)
            {   
                contador = 0;                
                imapres = 0;
                banderaOrdenados = true;
                
                numero = int.Parse(Console.ReadLine());
                min = numero;
                
                while(numero != 0)
                { 
                
                    contador ++;
                    if(numero % 2 != 0)
                        imapres++;

                    if(numero <= min)                    
                        min = numero;

                    else
                        banderaOrdenados = false;
                    
                    numero = int.Parse(Console.ReadLine());
                }

                porcentajeImpares = imapres * 100 / contador;

                if(porcentajeImpares > porcetajePar )
                {
                    porcetajePar = porcentajeImpares;
                    maximoImpar = x + 1;
                }

                if(banderaOrdenados)
                    conOrdenados++;
            }
            Console.WriteLine("El nro de grupo con mayor porcentajeImpares de nros impares es: " + maximoImpar );
            Console.WriteLine("El nro de grupos con nros ordenados son: " + conOrdenados ); 
    }
}
