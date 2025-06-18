namespace MyApp.Utils
{
    class TextAssets
    {
        public static void TextAppStart()
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

        public static void TextAppFinish()
        {
            Console.WriteLine("");
            Console.WriteLine("Obrigado por usar a calculadora!");
            Console.WriteLine("Console App desenvolvido por");
            Console.WriteLine($@"
  ___      _      _                 
 / _ \ ___(_) ___| |                
| | | / __| |/ _ \ |                
| |_| \__ \ |  __/ |                
 \___/|___/_|\___|_|    _           
|  \/  | ___(_)_ __ ___| | ___  ___ 
| |\/| |/ _ \ | '__/ _ \ |/ _ \/ __|
| |  | |  __/ | | |  __/ |  __/\__ \
|_|  |_|\___|_|_|  \___|_|\___||___/
        ");
        }
    }
}