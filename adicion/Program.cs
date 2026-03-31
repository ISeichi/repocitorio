using System;

class Suma
{
    static void Main()
    {
        Console.WriteLine("Calculadora Suma");
        Console.Write("Escribe el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Escribe el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        double resultado = n1 + n2;

        Console.WriteLine($"La suma de {n1} y {n2} es: {resultado}");
        if (resultado > 0)
        {
            Console.WriteLine("El resultado es positivo.");
        }
        else
        {
            Console.WriteLine("El resultado es negativo.");
        }
       
    }
}
