class TextAssets
{
    public static void TextWelcome()
    {
        Console.WriteLine("Seja bem vindo à Calculadora!");
        Console.WriteLine("Você precisará de dois números para fazer uma operação.");
        Console.WriteLine("=======================================================");

    }
    public static void TextTypeNumberOne()
    {
        Console.WriteLine("Digite o primeiro número: ");
    }

    public static void TextTypeNumberTwo()
    {
        Console.WriteLine("Digite o segundo número: ");
    }

    public static void TextMenuMsg()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Escolha qual das operações deseja fazer:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1 - SOMA");
        Console.WriteLine("2 - SUBTRAÇÃO");
        Console.WriteLine("3 - DIVISÃO");
        Console.WriteLine("4 - MULTIPLICAÇÃO");
        Console.WriteLine("0 - SAIR");
    }

    public static void TextTryNextMsg()
    {
        Console.WriteLine("");
        Console.WriteLine("Deseja fazer mais uma operação?");
        Console.WriteLine("Digite 'S' para SIM ou 'N' para NÃO");
    }
}