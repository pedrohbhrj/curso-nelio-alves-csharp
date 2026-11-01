using System.Globalization;

namespace CursoNelio.Exercicios;

public class ExercicioSecao3
{
    
    // Exercícios no pdf
    public static void ExercicioUm()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Soma = {a + b}");
    }

    public static void ExercicioDois()
    {
        double raioCirculo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
        double pi = 3.14159D;
        
        double area = pi * Math.Pow(raioCirculo, 2);

        Console.WriteLine($"A={area.ToString("F4",CultureInfo.InvariantCulture)}");
    }

    public static void ExercicioTres()
    {
        int a, b, c, d;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"DIFERENCA = {a * b - c * d}");
    }

    public static void ExercicioQuatro()
    {
        int numero, horasTrabalhadas;

       
        numero = int.Parse(Console.ReadLine());
        horasTrabalhadas = int.Parse(Console.ReadLine());
        
        double valorPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
        Console.WriteLine($"NUMBER = {numero}");
        Console.WriteLine($"SALARY = U$ {(horasTrabalhadas * valorPorHora).ToString("F2",CultureInfo.InvariantCulture)}");

    }

    public static void ExercicioCinco()
    {
        Console.WriteLine("--- Peca 1 ---");
        string[] peca1 = Console.ReadLine().Split(" ");
        Console.WriteLine("----- Peca 2 -----");
        string[] peca2 = Console.ReadLine().Split(" ");


        int quantidadePeca1 = int.Parse(peca1[1]);
        int quantidadePeca2 = int.Parse(peca2[1]);
        
        double valorUnitario1 = double.Parse(peca1[peca1.Length - 1],CultureInfo.InvariantCulture);
        double valorUnitario2 = double.Parse(peca2[peca2.Length - 1],CultureInfo.InvariantCulture);

        double valorAhPagar = (quantidadePeca1 * valorUnitario1) + (quantidadePeca2 * valorUnitario2);
     
        Console.WriteLine($"VALOR A PAGAR : R$ {valorAhPagar.ToString("F2",CultureInfo.InvariantCulture)}");
        
        
    }

    public static void ExercicioSeis()
    {
        string[] entradas = Console.ReadLine().Split(" ");

        double a, b, c;
        
        a = double.Parse(entradas[0],CultureInfo.InvariantCulture);
        b = double.Parse(entradas[1],CultureInfo.InvariantCulture);
        c = double.Parse(entradas[2],CultureInfo.InvariantCulture);

        double areaTrianguloRetangulo = a * c / 2 ;
        double areaDoCirculo = 3.1459 * Math.Pow(c,2);
        double areaDoTrapezio = (a + b) * c / 2;
        double areaDoQuadrado = Math.Pow(b,2);
        double areaDoRetangulo = a * b;
        
        Console.WriteLine($"TRIANGULO: {areaTrianguloRetangulo.ToString("F3",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {areaDoCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPÉZIO: {areaDoTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {areaDoQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {areaDoRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");

    }

    
    
}