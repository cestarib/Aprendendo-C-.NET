namespace Aula04;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("----- Login ----");
        // solicitar nome do usuario

        Console.WriteLine("Digite Seu Nome:");
        String name = Console.ReadLine();
        
        // solicitar a idade
        Console.WriteLine("Digite Sua Idade:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Seu nome é :" + name);
        Console.WriteLine("Sua Idade é: " + age);




    }



}
