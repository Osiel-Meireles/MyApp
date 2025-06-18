namespace MyApp.Models
{
    class Calculos
    {
        public static void Soma(double numeroUm, double numeroDois)
        {
            double operacao = numeroUm + numeroDois;
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Opção escolhida: SOMA");
            Console.WriteLine("");
            Console.WriteLine($"RESULTADO: {numeroUm} + {numeroDois} = {operacao}");

            Console.WriteLine($"Gostaria de verificar a raiz quadrada de {operacao}?");
            Console.WriteLine("Digite 'S' para SIM ou 'N' para NÃO");
            string opcaoSimOuNao = Console.ReadLine();
            switch (opcaoSimOuNao)
            {
                case "S":
                case "s":
                    Console.WriteLine($"A raiz quadrada de {operacao} é: {Math.Sqrt(operacao)}");
                    break;
                case "N":
                case "n":
                    break;
            }
        }

        public static void Subtracao(double numeroUm, double numeroDois)
        {
            double operacao = numeroUm - numeroDois;
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Opção escolhida: SUBTRAÇÃO");
            Console.WriteLine("");
            Console.WriteLine($"RESULTADO: {numeroUm} - {numeroDois} = {operacao}");

            Console.WriteLine($"Gostaria de verificar a raiz quadrada de {operacao}?");
            Console.WriteLine("Digite 'S' para SIM ou 'N' para NÃO");
            string opcaoSimOuNao = Console.ReadLine();
            switch (opcaoSimOuNao)
            {
                case "S":
                case "s":
                    Console.WriteLine($"A raiz quadrada de {operacao} é: {Math.Sqrt(operacao)}");
                    break;
                case "N":
                case "n":
                    break;
            }
        }

        public static void Divisao(double numeroUm, double numeroDois)
        {
            double operacao = numeroUm / numeroDois;
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Opção escolhida: DIVISÃO");
            Console.WriteLine("");
            Console.WriteLine($"RESULTADO: {numeroUm} / {numeroDois} = {operacao}");

            Console.WriteLine($"Gostaria de verificar a raiz quadrada de {operacao}?");
            Console.WriteLine("Digite 'S' para SIM ou 'N' para NÃO");
            string opcaoSimOuNao = Console.ReadLine();
            switch (opcaoSimOuNao)
            {
                case "S":
                case "s":
                    Console.WriteLine($"A raiz quadrada de {operacao} é: {Math.Sqrt(operacao)}");
                    break;
                case "N":
                case "n":
                    break;
            }
        }

        public static void Multiplicacao(double numeroUm, double numeroDois)
        {
            double operacao = numeroUm * numeroDois;
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Opção escolhida: MULTIPLICAÇÃO");
            Console.WriteLine("");
            Console.WriteLine($"RESULTADO: {numeroUm} * {numeroDois} = {operacao}");

            Console.WriteLine($"Gostaria de verificar a raiz quadrada de {operacao}?");
            Console.WriteLine("Digite 'S' para SIM ou 'N' para NÃO");
            string opcaoSimOuNao = Console.ReadLine();
            switch (opcaoSimOuNao)
            {
                case "S":
                case "s":
                    Console.WriteLine($"A raiz quadrada de {operacao} é: {Math.Sqrt(operacao)}");
                    break;
                case "N":
                case "n":
                    break;
            }
        }
    }
}