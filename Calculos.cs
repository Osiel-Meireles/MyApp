class Calculos
{
    public static void Soma(double numeroUm, double numeroDois)
    {
        double operacao = numeroUm + numeroDois;
        Console.WriteLine($"{numeroUm} + {numeroDois} = {operacao}");
    }

    public static void Subtracao(double numeroUm, double numeroDois)
    {
        double operacao = numeroUm - numeroDois;
        Console.WriteLine($"{numeroUm} - {numeroDois} = {operacao}");
    }

    public static void Divisao(double numeroUm, double numeroDois)
    {
        double operacao = numeroUm / numeroDois;
        Console.WriteLine($"{numeroUm} / {numeroDois} = {operacao}");
    }

    public static void Multiplicacao(double numeroUm, double numeroDois)
    {
        double operacao = numeroUm * numeroDois;
        Console.WriteLine($"{numeroUm} * {numeroDois} = {operacao}");
    }

}