namespace Aula10;
public class Program
{
    public static void Main()
    {
        //bool bollValue = true;

        //switch (bollValue)
        //{
        //    case true:
        //        Console.WriteLine("o numero é true");
        //        break;
        //    case false:
        //        Console.WriteLine("o numero é true");
        //        break;

        //}

        //ex 2

        //Console.WriteLine("======Dias da semana======");
        //Console.WriteLine("\nDigite um numero de 1 a 7 ");
        //int dayWeek = Convert.ToInt32(Console.ReadLine());

        //switch (dayWeek)
        //{
        //    case 1:
        //        Console.WriteLine("O dia da semana é Domingo");
        //        break;
        //    case 2:
        //        Console.WriteLine("O dia da semana é Segunda");
        //        break;
        //    case 3:
        //        Console.WriteLine("O dia da semana é terça");
        //        break;
        //    case 4:
        //        Console.WriteLine("O dia da semana é quarta");
        //        break;
        //    case 5:
        //        Console.WriteLine("O dia da semana é quinta");
        //        break;
        //    case 6:
        //        Console.WriteLine("O dia da semana é sexta");
        //        break;
        //    case 7:
        //        Console.WriteLine("O dia da semana é sabado");
        //        break;

        //    default:
        //        Console.WriteLine("Dia invalido");
        //        break;

        //ex 3

        Console.WriteLine("====desempenho escolar====");
        Console.WriteLine("digite sua nota:");
        var score = Console.ReadLine();

        switch (score)
        {
            case "mb":
                 Console.WriteLine("Otimo");
                break;
            case "b":
                 Console.WriteLine("bom");
                break;
            case "s":
                Console.WriteLine("ficando ruim");
                break;
            default:
                Console.WriteLine("horrivel");
                break;

        }

        
    }
}