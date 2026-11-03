namespace CursoNelio.Exercicios.ExercicioSecao6;

public class ExercicioVetor
{
    public static void ExecutarExercicio()
    {
        
        PessoaVetor[] pessoas = new PessoaVetor[10];
        Console.Write($"Quantas salas vao ser alugadas:");
        int alugado = int.Parse(Console.ReadLine());
        
        int count = 0;

        while (count != alugado)
        {
            count++;
            Console.WriteLine($"Quarto #{count}:");
        
           
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write($"Email: ");
            string email = Console.ReadLine();
            Console.Write($"Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            pessoas[quarto] = new PessoaVetor(nome,email,quarto);
        }


        Console.WriteLine("Quartos ocupados: ");
        for (int i = 0; i < pessoas.Length; i++)
        {
            if (pessoas[i] != null)
            {
                Console.WriteLine($"{i}: {pessoas[i]}");
            }
        }
        
        
        
    }
}