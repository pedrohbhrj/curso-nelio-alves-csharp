namespace CursoNelio.Secao8EnumComposicao;

public class TiposEnumerados
{



    // exemplo
    enum DiasDaSemana
    {
        SEGUNDA = 1,
        TERCA = 2,
        QUARTA = 3,
        QUINTA = 4,
        SEXTA = 5,
        SABADO = 6,
        DOMINGO = 7
    }


    public static void MostrarDiasDaSemana()
    {
        Console.WriteLine(DiasDaSemana.SEGUNDA);
        Console.WriteLine(DiasDaSemana.TERCA);
        Console.WriteLine(DiasDaSemana.QUARTA);
        Console.WriteLine(DiasDaSemana.QUINTA);
        Console.WriteLine(DiasDaSemana.SEXTA);
        Console.WriteLine(DiasDaSemana.SABADO);
        Console.WriteLine(DiasDaSemana.DOMINGO);

        DiasDaSemana x = Enum.Parse<DiasDaSemana>("SEGUNDA");
        
        Console.WriteLine(x);
    }
}