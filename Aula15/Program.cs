namespace Aula15;
public class Program
{
    public static void Main()
    {
        // coleçoes  (lista)

        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach (int i in list)
        {
            //faça algo
            Console.WriteLine(i);
        }
    }
}

