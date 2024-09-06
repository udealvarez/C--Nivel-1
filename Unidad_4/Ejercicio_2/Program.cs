namespace Ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // EJERCICIO 2

        /*
            Un importante negocio de desinfectante líquido realiza descuentos dependiendo
            de la cantidad de litros vendidos según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            Hacer un programa que solicite el ingreso del importe total de la venta y 
            la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
        */
        
        double importe = 0, litros = 0, montoTotal = 0;

        Console.WriteLine("Ingrese el importe de la venta: ");
        importe = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de litros: ");
        litros = double.Parse(Console.ReadLine());

        if (litros > 500)        
            montoTotal = importe * 0.75;
        else if(litros > 300)
            montoTotal = importe * 0.85;
        else if(litros > 100)
            montoTotal = importe * 0.9;
        else
            montoTotal = importe;

        Console.WriteLine("El monto total es de: " + montoTotal);   

    }
}
