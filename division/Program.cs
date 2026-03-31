

class Division
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresar primer número");

        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresar segundo número");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > 0)
        {
            int division = a / b ;
            Console.WriteLine("La división es :" + division);
        }
        else
        {
            Console.WriteLine("La división no se puede realizar por ser número menor que 0");
        }

    }
}