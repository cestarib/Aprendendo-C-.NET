using System.ComponentModel.Design;

namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=========Verificador De Numeros Pares ou Impares========");

        Console.WriteLine("Digite o numero:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        int result = number1 % 2;

        if (result == 0)
        {
            Console.WriteLine("É par !");


        }
        else
        {
            Console.WriteLine("É impar !");
        } 
        

     

    




    }




}