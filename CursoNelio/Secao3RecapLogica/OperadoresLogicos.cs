namespace CursoNelio.Secao3RecapLogica;

public class OperadoresLogicos
{
    public static void MostrarOperadoresLogicos()
    {
        
        bool verdadeiro = true;
        
        bool falso = false;

        // Se as duas condições forem verdadeiras , entra no if;
        if (verdadeiro && !falso)
        {
            Console.WriteLine("Operador Lógico AND"); 
        }
        // primeira condicao que for verdadeira , pode-se fazer algo
        if (verdadeiro || !falso)
        {
            Console.WriteLine("Operador logico OR , ||");
        }
        
        // em ambos os exemplos foi usado o terceiro operador que e o NOT , -> !
        Console.WriteLine(!!false);
    }
}