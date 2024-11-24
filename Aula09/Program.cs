namespace Aula09;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Operadores Logicos=====");

        bool isLogged = false;
        bool AdminAcess = true;

        Console.WriteLine("\nInformaçoes do Usuario:");
        Console.WriteLine("Usuario Logado: " +isLogged);
        Console.WriteLine("Acesso Administrador :" +AdminAcess);

        Console.WriteLine("\nPermições do Usuario:");

        // operador (||) ou

        if (isLogged || AdminAcess)
        {
            Console.WriteLine("Usuario tem acesso ao sistema.");
        }
        else
        {
            Console.WriteLine("Acesso negado ao sistema.");
        }

        // operado (&&) e

        if (isLogged &&  AdminAcess)
        {
            Console.WriteLine("Acesso Admin liberado.");
        }
        else
        {
            Console.WriteLine("Acesso Admin negado");
        }

        // operador (!) negação

        if (!isLogged)
        {
            Console.WriteLine("Sem acesso ao sistema.");
        }
        else
        {
            Console.WriteLine("Acesso liberado ao sistema.");
        }

    }

}
