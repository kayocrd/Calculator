﻿Console.Clear();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Bem vindo a Kalculator!");
Console.WriteLine("_______________________________________________ \n");

Menu();

static void Menu()
{
  Console.Clear();
  Console.WriteLine("O que deseja fazer?");
  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtração");
  Console.WriteLine("3 - Multiplicação");
  Console.WriteLine("4 - Divisão");
  Console.WriteLine("5 - Sair");
  Console.WriteLine("_______________________________________________ \n");
  Console.Write("Digite a opção desejada: ");

  Globals.opcao = Console.ReadLine();
  while (Globals.opcao != "1"
  && Globals.opcao != "2"
  && Globals.opcao != "3"
  && Globals.opcao != "4"
  && Globals.opcao != "5")
  {
    Console.Clear();
    Console.WriteLine("Opção inválida!");
    Console.Write("Digite a opção desejada: ");
    Globals.opcao = Console.ReadLine();
  }
  if (Globals.opcao == "5")
  {
    Console.WriteLine("Obrigado por utilizar o Kalculator!");
    Environment.Exit(0);
  }
  else
  {
    Calculadora();
  }
}

static void Calculadora()
{

  Console.Clear();
  Console.WriteLine("_______________________________________________ \n");
  Console.WriteLine("Digite os dois números que deseja calcular: \n");
  Console.Write("Digite o primeiro número: ");
  //somente numeros sao aceitos
  Globals.num1 = Console.ReadLine();
  while (!float.TryParse(Globals.num1, out float num1))
  {
    Console.Clear();
    Console.WriteLine("Número inválido!");
    Console.Write("Digite o primeiro número: ");
    Globals.num1 = Console.ReadLine();
  }
  Console.Write("Digite o segundo número: ");
  Globals.num2 = Console.ReadLine();
  while (!float.TryParse(Globals.num2, out float num2))
  {
    Console.Clear();
    Console.WriteLine("Número inválido!");
    Console.Write("Digite o segundo número: ");
    Globals.num2 = Console.ReadLine();
  }
  Console.WriteLine("_______________________________________________ \n");
  Console.WriteLine("Processando...: ");
  Console.Clear();

  switch (Globals.opcao)
  {
    case "1": Soma(int.Parse(Globals.num1), int.Parse(Globals.num2)); break;
    case "2": Subtracao(int.Parse(Globals.num1), int.Parse(Globals.num2)); break;
    case "3": Multiplicacao(int.Parse(Globals.num1), int.Parse(Globals.num2)); break;
    case "4": Divisao(int.Parse(Globals.num1), int.Parse(Globals.num2)); break;
    default:
      Console.WriteLine("Opção inválida!");
      Menu(); break;
  }
}

static void Soma(float num1, float num2)
{
  var result = num1 + num2;
  Console.WriteLine($"O Resultado da Soma é: {result}");
  Console.ReadKey();
}

static void Subtracao(float num1, float num2)
{
  var result = num1 - num2;
  Console.WriteLine($"O Resultado da Subtração é: {result}");
  Console.ReadKey();
}

static void Divisao(float num1, float num2)
{
  var result = num1 / num2;
  Console.WriteLine($"O Resultado da Divisão é: {result}");
}

static void Multiplicacao(float num1, float num2)
{
  var result = num1 * num2;
  Console.WriteLine($"O Resultado da Multiplicação é: {result}");
}
public static class Globals
{
  public static string opcao;
  public static string num1;
  public static string num2;
}