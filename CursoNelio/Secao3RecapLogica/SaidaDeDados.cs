namespace CursoNelio.Secao3RecapLogica;

public class SaidaDeDados
{
    public static string Nome = "Pedro";
    public static int Idade = 28;
    public static string Sexo = "Masculino";
    public static double DinheiroGuardado = 1500D;
    public static readonly DateTime DataAtual = DateTime.Now;
    public static void VerDados()
    {
        // Interpolação de strings
        Console.WriteLine($"Nome: {Nome}, idade: {Idade} , Sexo: {Sexo}");
        
        // Placeholders
        Console.WriteLine("Nome: {0}, idade: {1} , Sexo: {2}", Nome, Idade, Sexo);
        
        // Concatenação de strings
        Console.WriteLine("Nome: " + Nome + " idade: " + Idade + " , Sexo: " + Sexo);
        
        
        // Formataçao de Números
        Console.WriteLine($"Dinheiro guardado com duas casas decimais: {DinheiroGuardado:F2}");
        
        // Valor monetário
        Console.WriteLine($"Dinheiro formatado pela moeda de origem: {DinheiroGuardado:C}");
        
        // Formatação de Data
        Console.WriteLine($"Formatação de Data: {DataAtual:dd/MM/yyyy HH:mm:ss}");
        
    }
    
}