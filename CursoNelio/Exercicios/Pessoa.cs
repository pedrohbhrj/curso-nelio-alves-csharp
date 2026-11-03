using System.Globalization;

namespace CursoNelio.Exercicios;

public class Pessoa
{
    public string Nome;
    public double Salario;
    public int Idade;

    public Pessoa(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }


    public static void ExercicioUmOrientacaoObjetos()
    {
        Pessoa p1 = new Pessoa("Maria",17);
        Pessoa p2 = new Pessoa("Joao", 16);

        string maisVelho = p1.Idade > p2.Idade ? p1.Nome : p2.Nome;
        
        Console.WriteLine("Dados da primeira pessoa:");
        Console.WriteLine($"Nome: {p1.Nome}");
        Console.WriteLine($"Nome: {p1.Idade}");
        Console.WriteLine("Dados da segunda pessoa:");
        Console.WriteLine($"Nome: {p2.Nome}");
        Console.WriteLine($"Nome: {p2.Idade}");
        Console.WriteLine($"Pessoa mais velha: {maisVelho}");
    }
    public static void ExercicioDoisOrientacaoObjetos()
    {
        Pessoa p1 = new Pessoa("Carlos Silva",6300.00);
        Pessoa p2 = new Pessoa("Ana Marques", 6700);
        
        Console.WriteLine("Dados do primeiro funcionario:");
        Console.WriteLine($"Nome: {p1.Nome}");
        Console.WriteLine($"Salario: {p1.Salario.ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine("Dados do segundo funcionario:");
        Console.WriteLine($"Nome: {p2.Nome}");
        Console.WriteLine($"Salario: {p2.Salario.ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Salario medio = {((p1.Salario + p2.Salario) / 2).ToString("F2",CultureInfo.InvariantCulture)}");
    }
}