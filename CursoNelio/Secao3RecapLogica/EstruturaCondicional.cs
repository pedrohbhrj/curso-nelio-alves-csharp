namespace CursoNelio.Secao3RecapLogica;

public class EstruturaCondicional
{

    public static void MostrarEstruturaCondicional()
    {
        // Se condicao for verdadeira , entramos no bloco de codigo.
        if (true)
        {
            Console.WriteLine("Entrei no IF");
        }

        // Se condicao for verdadeira , entramos no bloco de codigo.
        // Se a condicao que especificamos nao for exatamente igual , a gente entra em outros casos
        string a = Console.ReadLine();
        if (a.Length > 2)
        {
            Console.WriteLine("Sou uma string com mais de dois caracteres");
        }
        else
        {
            Console.WriteLine("Sou uma string com dois ou menos caracteres");
        }
        
        //Estrutura composta checando mais de um caso especifico,
        //podemos adicionar quantos else-ifs quisermos
        if (a.Length > 2)
        {
            Console.WriteLine("Sou uma string com mais de dois caracteres");
        }
        else if (a.Length < 2)
        {
            Console.WriteLine("Sou uma string com menos de dois caracteres");
        }
        else
        {
            Console.WriteLine("Sou uma string com dois caracteres");
        }
}

}