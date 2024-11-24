namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("======Calculadora Bem Simples======");
        Console.WriteLine("Digite o primeiro numero:");
        int number1 = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Digite o segundo numero:");
        int number2 = Convert.ToInt32(Console.ReadLine());




        int sun = number1 + number2;
        int subtraction = number2 - number1;
        int division = number2 / number1;
        int module = number2 % number1;
        int multiplication = number1 * number2;

        Console.WriteLine("a soma dos numeros é:" + sun);
        Console.WriteLine("a subtração dos numeros é:" + subtraction);
        Console.WriteLine("a multiplicação dos numeros é:" + multiplication);
        Console.WriteLine("a divisão dos numeros é:" + division);
        Console.WriteLine("o resto da divisão é:" + module);





    }


}
