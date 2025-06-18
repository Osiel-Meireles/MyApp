using MyApp.Models;
using MyApp.Utils;

namespace MyApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        TextAssets.TextAppStart();
        TextAssets.TextTypeNumberOne();
        double numeroUm = double.Parse(Console.ReadLine());
        TextAssets.TextTypeNumberTwo();
        double numeroDois = double.Parse(Console.ReadLine());
        TextAssets.TextMenuMsg();

        int numeroDaOpcao = int.Parse(Console.ReadLine());
        string opcaoSimOuNao = "";

        while (numeroDaOpcao > 0)
        {
            switch (numeroDaOpcao)
            {
                case 1:
                    Calculos.Soma(numeroUm, numeroDois);
                    break;
                case 2:
                    Calculos.Subtracao(numeroUm, numeroDois);
                    break;
                case 3:
                    Calculos.Divisao(numeroUm, numeroDois);
                    break;
                case 4:
                    Calculos.Multiplicacao(numeroUm, numeroDois);
                    break;
                default:
                    Console.WriteLine("Opção não encontrada!");
                    break;
            }

            TextAssets.TextTryNextMsg();
            opcaoSimOuNao = Console.ReadLine();

            switch (opcaoSimOuNao)
            {
                case "S":
                case "s":
                    TextAssets.TextMenuMsg();
                    numeroDaOpcao = int.Parse(Console.ReadLine());
                    break;
                case "N":
                case "n":
                    numeroDaOpcao = 0;
                    break;

            }
        }
        TextAssets.TextAppFinish();
    }
}
