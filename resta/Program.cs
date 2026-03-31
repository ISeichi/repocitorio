using System;
class Resta
{
static void Main()
{
double a;
double b;
double c;

Console.WriteLine("Genere su Resta");
Console.WriteLine("Escriba su primer numero: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escriba su segundo numero: ");
b = Convert.ToDouble(Console.ReadLine());

c = a-b;
Console.WriteLine("Su respuesta es: " + c);

}
}