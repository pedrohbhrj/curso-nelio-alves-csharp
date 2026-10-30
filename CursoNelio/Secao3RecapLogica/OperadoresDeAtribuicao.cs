namespace CursoNelio.Secao3RecapLogica;

public class OperadoresDeAtribuicao
{


    public static void OperadoresMostrar()
    {
        int a = 10;
        Console.WriteLine(a);
        
        a += 2;
        Console.WriteLine(a);
        
        a /= 2;
        Console.WriteLine(a);
        
        a *= 2;
        Console.WriteLine(a);

        string s = "ABC";
        
        s += "DEF";
        Console.WriteLine(s);

        int count = 0;
        Console.WriteLine(count);
        count++;
        Console.WriteLine(count);
        count--;
        Console.WriteLine(count);
        
    }
}