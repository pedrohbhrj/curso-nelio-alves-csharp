namespace CursoNelio.Secao3RecapLogica;

public class ConversaoImplicitaExplicita
{



    public static void ImprimirCasting()
    {
        // Conversão implicita
        int numeroInt = 123;
        double numeroDouble = numeroInt;
        Console.WriteLine(numeroDouble);
        
        
        // Conversão explicita
        int numeroInt2 = 123;
        double numeroDouble2 = (double)numeroInt2;
        
        
        // Usando a classe convert
        double numeroParaTrocarComConvert = 123.54D;
        int numeroInteiro = Convert.ToInt32(numeroParaTrocarComConvert);
        Console.WriteLine(numeroInteiro);
        
        // Usando metodos Parse() e TryParse()
        int idade = int.Parse("28");

        string entrada = "123a";

        if (int.TryParse(entrada, out int resultado))
        {
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Texto inválido para conversão.");
        }
    }
}