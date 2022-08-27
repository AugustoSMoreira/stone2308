Start();
static void Start()
{
  Options();
  Start();
}
static void Options()
{
  Console.Clear();

  Console.WriteLine("Olá, nosso sistema avalia o rendimento do seu funcionário");
  Console.WriteLine("Qual o nome do seu funcionário?");
  var name = Console.ReadLine();

  Console.WriteLine("D - Para renda diária?");
  Console.WriteLine("A - Para renda anual?");
  Console.WriteLine("0 - Para Sair");
  var option = char.Parse(Console.ReadLine().ToLower());

  switch (option)
  {
    case 'd':
      Daily(name);
      break;
    case 'a':
      Yearly(name);
      break;
    case '0':
      Console.WriteLine("Até a próxima");
      Thread.Sleep(2000);
      System.Environment.Exit(0);
      break;
    default:
      Console.WriteLine("Por favor, Escolha uma opção válida");
      Console.WriteLine("Aperte Enter para Continuar ...");
      Console.ReadKey();
      break;
  }
}
static void Daily(string name)
{
  Console.Clear();

  Console.WriteLine($"Quanto {name} recebe por mês?");
  var salary = double.Parse(Console.ReadLine());

  var result = Math.Round(salary / 30);

  Console.WriteLine($"{name} recebe R${result} por dia");
  Console.ReadKey();
}
static void Yearly(string name)
{
  Console.Clear();

  Console.WriteLine($"Quanto {name} recebe por mês?");
  var salary = double.Parse(Console.ReadLine());

  var result = Math.Round(salary * 12);

  Console.WriteLine($"{name} recebe R${result} por ano");
  Console.ReadKey();
}