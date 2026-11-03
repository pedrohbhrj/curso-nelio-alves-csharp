namespace CursoNelio.Exercicios.ExercicioSecao6;

public class PessoaVetor
{ 
    private string Nome { get; set; }
    private string Email { get; set; }
    
    public int Quarto { get;}
    
    public PessoaVetor(string nome, string email,int quarto)
    {
        Nome = nome;
        Email = email;
        Quarto = quarto;
    }


    public override string ToString()
    {
        return $"{Nome} , {Email}";
    }
}