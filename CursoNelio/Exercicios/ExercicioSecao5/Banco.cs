using System.Globalization;

namespace CursoNelio.Exercicios.ExercicioSecao5;

public class Banco
{
    private string _nome { get; set; }
    private int _numeroConta { get; }
    private decimal _saldo { get; set; }


    public Banco(string nome, int numeroConta, decimal saldo)
    {
        _nome = nome;
        _numeroConta = numeroConta;
        _saldo = saldo;
    }

    public Banco()
    {
        
    }
    
    public Banco(string nome, int numeroConta)
    {
        _nome = nome;
        _numeroConta = numeroConta;
        _saldo = 0;
    }

    
    public override string ToString()
    {
        return $"Conta {_numeroConta}, Titular: {_nome}, Saldo: $ {_saldo.ToString("F2",CultureInfo.InvariantCulture)}" ;
    }
    
    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            _saldo += valor;
            Console.WriteLine($"Dados da conta atualizados: \n");
            Console.WriteLine(ToString());
        }
        else
        {
            Console.WriteLine($"Nao podemos adicionar este tipo de valor: {valor}");
        }
        
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine($"Nao podemos sacar este tipo de valor: {valor}");
        }
        else if (_saldo < valor)
        {
            Console.WriteLine($"Nao podemos sacar um valor maior que o saldo");
        }
        else
        {
            bool verificaSePodePagarTaxa = _saldo - valor >= 5;
            if (verificaSePodePagarTaxa)
            {
                _saldo -= valor;
                _saldo -= 5;
                Console.WriteLine($"Dados da conta atualizados: \n");
                Console.WriteLine(ToString());
            }
            else
            {
                Console.WriteLine("Nao tem dinheiro suficiente para pagar a taxa");
            }
        }
    }
    
    
}