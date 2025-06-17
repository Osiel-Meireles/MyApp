namespace MyApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite dois números para soma. Digite o primeiro, pressione ENTER e digite o segundo.");
        double numeroUm = double.Parse(Console.ReadLine());
        double numeroDois = double.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("Escolha qual das operações deseja fazer:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1 - SOMA");
        Console.WriteLine("2 - SUBTRAÇÃO");
        Console.WriteLine("3 - DIVISÃO");
        Console.WriteLine("4 - MULTIPLICAÇÃO");
        Console.WriteLine("0 - SAIR");

        int numeroDaOpcao = int.Parse(Console.ReadLine());

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
            Console.WriteLine("Digite a opção que deseja.");
            numeroDaOpcao = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Obrigado por usar a calculadora.");
    }
}
