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

    public static void ExecutarExercicioMatriz()
    {
        string[] tamanhoMatriz = Console.ReadLine().Split(" ");
        
        int linha = int.Parse(tamanhoMatriz[0]);
        int coluna = int.Parse(tamanhoMatriz[1]);
        
        int[,] matriz = new int[linha,coluna];
        string[] entrada;
        
        for (int i = 0; i < linha; i++)
        {
            entrada = Console.ReadLine().Split(" ");
            
            for (int j = 0; j < coluna; j++)
            {
                matriz[i, j] = int.Parse(entrada[j]);
            }
        }
        
        int valorAhEncontrar = int.Parse(Console.ReadLine());

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                
                if (matriz[i, j] == valorAhEncontrar)
                {
                    
                    Console.WriteLine($"Position {i},{j}:");
                    
                    if (j - 1 < 0)
                    {
                        continue;
                    }
                       
                    int left = matriz[i, j - 1];
                    Console.WriteLine($"Left: {left}");
                    
                    if (j + 1 < coluna)
                    {
                        int right = matriz[i, j + 1];
                        Console.WriteLine($"Right: {right}");
                    }
                    
                    if (i + 1 < linha)
                    {
                        int down = matriz[i + 1, j];
                        Console.WriteLine($"Down: {down}");
                    }
                    
                    
                    if (i - 1 >= 0)
                    {
                        int up = matriz[i - 1, j];
                        Console.WriteLine($"Up: {up}");
                    }
                    
                    
                }
            }
        }
        
    }
}