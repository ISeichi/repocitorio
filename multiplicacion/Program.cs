using System;

class Multiplicacion
{
    static void Main()
    {
        double n1;
        double n2;
        double multi;
        Console.WriteLine("Multiplicación");
        Console.WriteLine("Escriba el primer númnero:");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escriba el segundo número:");
        n2 = Convert.ToDouble(Console.ReadLine()); 
        multi = n1 * n2;
        Console.WriteLine($"El resultado es: {multi}");
    }
}