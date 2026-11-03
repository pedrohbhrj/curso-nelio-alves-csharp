namespace CursoNelio.Exercicios.ExercicioSecao5;

public class ExercicioSecao5
{
    public static void ExecutarExercicio()
    {
        int numeroConta;
        string titularConta;
        char confirmacao;
        decimal saldo = 0;
        
        Console.WriteLine($"Entre o numero da conta:");
        numeroConta = int.Parse(Console.ReadLine());
        Console.WriteLine($"Entre o titular da conta:");
        titularConta = Console.ReadLine();
        Console.WriteLine($"Havera deposito inicial (s/n) ?");
        confirmacao = char.Parse(Console.ReadLine());
        
        
        if (confirmacao == 's')
        {
            Console.WriteLine($"Entre o valor de deposito inicial:");
            saldo = decimal.Parse(Console.ReadLine());
        }
        
        Banco conta = new Banco(titularConta,numeroConta,saldo);
        Console.WriteLine($"Dados da conta: \n{conta}");

        decimal valorDeposito;
        decimal valorSaque;
        
        Console.WriteLine($"Entre um valor para deposito:");
        valorDeposito = decimal.Parse(Console.ReadLine());
        conta.Depositar(valorDeposito);
        Console.WriteLine($"Entre um valor para saque:");
        valorSaque = decimal.Parse(Console.ReadLine());
        conta.Sacar(valorSaque);
    }
}