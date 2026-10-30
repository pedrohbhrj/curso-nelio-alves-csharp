namespace CursoNelio.Secao3RecapLogica;

public class OperadoresAritmeticos
{
    public static void VerOperadores()
    {
        int a = 10;
        int b = 20; 

        // Operações
        int resultadoSoma = a + b;
        int resultadoMult = a * b;
        int resultadoDiv = a / b;
        int resultadoMod = b % a;
        int resultadoSub = a - b;
        
        
        
        // Procedencia é de * , / , % ou entre () ;
        // Primeiro parenteses e depois operadores principais , como * , / , %
        int resultadoProcedencia = (a + b) * (10 / 2) % 1;
        Console.WriteLine(resultadoProcedencia);
    }
}