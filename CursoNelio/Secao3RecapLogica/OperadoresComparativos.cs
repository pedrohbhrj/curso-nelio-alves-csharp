namespace CursoNelio.Secao3RecapLogica;

public class OperadoresComparativos
{

    public static void MostrarOpComparativos()
    {
        // > Maior que
        // < Menor que
        // != Diferente de
        // == Igual a
        // >= Maior ou igual a
        // <= Menor ou igual a
        Console.WriteLine("> , < , >= , <= , != , ==");
        
        // Exemplos práticos
        // falso
        bool umMaiorQueDois = 1 > 2;
        // true
        bool doisMaiorQueUm = 2 > 1;
        // true
        bool umEhIgualAhUm = 1 == 1;
        // true
        bool doisEhMaiorOuIgualAhDois = 2 >= 2;
        // true
        bool doisEhMenorOuIgualAhDois = 2 <= 2;
        // true
        bool doisEhDiferenteDeUm = 2 != 1;
        
    }
}