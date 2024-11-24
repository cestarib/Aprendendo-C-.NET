namespace Aula14;
public class Program
{
    public static void Main()
    {
        /* for (condição1;condição2;condição3);
         * 
         * condição 1 executada uma unica vez
         * condição 2 define a condição para executao o bloco de codigo
         * condição 3 executado doas as vezes
         * */

        //for (int i = 0; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //ex 2

        Console.WriteLine("======tabela de multiplicação=======");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,6}");
            }
            Console.WriteLine();
        }
    }
}