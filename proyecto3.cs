using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Que desea realizar? +, *, o /");
        string calculo = Console.ReadLine();
        Console.WriteLine("Indique su primer numero a sumar, multiplicar o restar: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Indique su segundo numero a sumar, multiplicar o restar : ");
        int n2 = int.Parse(Console.ReadLine());
        int suma1 = n1 + n2;
        int suma2 = n1 * n2;
        int suma3 = n1 / n2;
    
        if(calculo == "+")
        {
            Console.WriteLine("La suma es igual a: " + suma1);
        }
        else if(calculo == "*")
        {
            Console.WriteLine("La multiplicación es igual a: " + suma2);
        }
        else if(calculo == "/")
        {
            Console.WriteLine("La división es igual a: " + suma3);
        }
    }
}