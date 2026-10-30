namespace CursoNelio.Secao3RecapLogica;

public class TiposDeDados
{
    static char caractere = 'a';
    static int n1 = 123;
    static double n2 = 123.54D;
    static decimal n3 = 123.45M;
    static float n4 = 123.45F;
    static string nome = "Pedro";
    static byte n5 = 123;
    static short n6 = 123;
    static long n7 = 123L;
    static bool completo = true;
    static object obj1 = "Pedrao";
    static object obj2 = 1;

    

    public static void ExibirDados()
    {
        Console.WriteLine(nome + "" + caractere + n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5 + " " + n6 + " " + n7 + " " + completo);
    }

    public static void ExibirMenorNumeroAndMaiorNumero()
    {
        
        int menorNumero = int.MinValue;
        int maiorNumero = int.MaxValue;
        
        Console.WriteLine(menorNumero);
        Console.WriteLine(maiorNumero);
        
    }
    
}