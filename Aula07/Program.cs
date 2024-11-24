namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Atribuiçoes=====");
        //iniciando a variavel
        int x = 10;
        Console.WriteLine("\no valor inicial da variavel é : " +x );

        //operador d atribuição simples
        Console.WriteLine("\ndigite um valor para atribuir a x :");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\no novo valor de x é:" +x);

        //operador composto (++)
        x++; //equivale a x = x + 1 

        Console.WriteLine("\natribuição composta (++)");
        Console.WriteLine("o novo valor de x é:" +x);

        // operador composto (+=)
        x +=10; // equivale a x = x + 10

        Console.WriteLine("\natribuição composta (+=)");
        Console.WriteLine("o novo valor de x é:" + x);

        // operador composto (-=)
        x -= 10; // equivale a x = x - 10

        Console.WriteLine("\natribuição composta (-=)");
        Console.WriteLine("o novo valor de x é:" + x);

        // operador composto (*=)
        x *= 10; // equivale a x = x * 10

        Console.WriteLine("\natribuição composta (*=)");
        Console.WriteLine("o novo valor de x é:" + x);

        // operador composto (/=)
        x /= 10; // equivale a x = x / 10

        Console.WriteLine("\natribuição composta (/=)");
        Console.WriteLine("o novo valor de x é:" + x);











    }



}

