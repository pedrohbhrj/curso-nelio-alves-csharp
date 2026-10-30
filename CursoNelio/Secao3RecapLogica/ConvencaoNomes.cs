namespace CursoNelio.Secao3RecapLogica;

public class ConvencaoNomes
{
    private static string Nome {get;set;}
    private static readonly string _descricao = "Sou uma descricao de convencao";
    private const int TamanhoMaximo = 100;

    public static void VerAtributos()
    {
        Console.WriteLine(Nome);
        Console.WriteLine(_descricao);
        Console.WriteLine(TamanhoMaximo);
    }
    
    
}