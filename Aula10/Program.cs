using System.ComponentModel.Design;

namespace Aula10;
public class Program
{
    public static void Main()
    {
        bool Contloop = true;

        while (Contloop) { 
        
        
        Console.WriteLine("======Calculadora Simples======");
        Console.WriteLine("\nDigite o primeiro valor:");
        double num1 = Convert.ToDouble( Console.ReadLine());
        Console.WriteLine("\nDigite o segundo valor:");
        double num2 = Convert.ToDouble( Console.ReadLine());

        //selecionar o tipo de operação

        Console.WriteLine("\nSelecione o numero operação que deseja efetuar:\n");
        Console.WriteLine("1. Adição (+)");
        Console.WriteLine("2. Subtração (-)");
        Console.WriteLine("3. Multiplicação (*)");
        Console.WriteLine("4. Divisão (/)");
        Console.WriteLine("\n\nDigite o numero da operação:");
        int operation = Convert.ToInt32( Console.ReadLine() );

        double result = 0;

        // condiçoes

        if ( operation == 1)
        {
            result = num1 + num2;
        }
        else if ( operation == 2)
        {
            result = num1 - num2;
        }
        else if( operation == 3)
        {
            result = num2 * num1;
        }
        else if (operation == 4)
        {
           if ( num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Erro : Não é possivel dividir por 0");
            }
        }
        else
        {
            Console.WriteLine("Escolha uma opção valida (1-4)");
        }
        Console.WriteLine("Resultado da operção é : " +result);


            Console.WriteLine("\nDeseja realizar outra operação ? (s/n)");
            string resp1 = Console.ReadLine();

            if (resp1 != "s")
            {
             Contloop = false;
            }
             
               

        }

        Console.WriteLine("Obrigado por usar a calculadora by: bnovrs");

    }
}
