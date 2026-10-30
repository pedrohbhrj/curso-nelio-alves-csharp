namespace CursoNelio.Secao3RecapLogica;

public class EntradaDeDados
{




    public static void Executar()
    {


        while (true)
        {
        
            Console.WriteLine("Digite seu nome.");
            string nome = Console.ReadLine();
        
            Console.WriteLine("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
        
            Console.WriteLine("Digite a idade");
            string idade = Console.ReadLine();


            if (int.TryParse(idade, out int resultado))
            {
                Console.WriteLine("Idade validada");
            }
            else
            {
                Console.WriteLine("Idade invalida");
                continue;
            }
        
        
            Console.WriteLine("Digite o nome de seus gatos !");
            string[] nomeDosGatos = Console.ReadLine().Split(" ");
        
            Console.WriteLine($"{nome} - {sobrenome} - {idade}");
        
            foreach (var nomeGato in nomeDosGatos)
            {
                Console.Write($"{nomeGato} ");
            }


            break;

        }
        

    }
}