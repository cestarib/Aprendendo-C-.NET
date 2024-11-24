namespace Aula08;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("======Operadores Relacionais======");
        Console.WriteLine("Digite o numero para X:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o numero para Y" );
        int y = Convert.ToInt32(Console.ReadLine());

        string result;

        //operador de igualdade (==)

        if (x == y)
        {
            result = "X é igual a Y";
        }
        else {
           result = "X é diferente de Y";
        }
        Console.WriteLine("igualdade (==)" +result);

        //operador de diferença (!=)

        if (x != y)
        {
            result = "X e Y são diferentes";
        }
        else
        {
            result = "X e Y nao sao diferentes";
        }
        Console.WriteLine("diferença (!=)" +result );

        //operador maior q (>)

        if (x > y) {
            result = "X é maior que Y";
                }
        else
        {
            result = "X não é maior que Y";
        }
        Console.WriteLine("maior que (>)" +result );

        //operador menor q (<)

        if (x < y)
        {
            result = "X é menor que Y";
        }
        else
        {
            result = "X não é menor que Y";
             }
        Console.WriteLine("menor que (<)" + result );

        //operador maior igual (>=)

        if (x >= y)
        {
            result = "X é maior igual a Y";
        }
        else
        {
            result = "X não é maior igual a Y";
        }

        Console.WriteLine("maior igual (>=) " + result);

        //operador menor igual (<=)

        if (x <= y)
        {
            result = "X é menor igual a Y";
        }
        else
        {
            result = "X não é menor igual a Y";

        }
        Console.WriteLine("menor igual (<=) " + result);
    }

}