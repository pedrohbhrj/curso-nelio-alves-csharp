namespace CursoNelio.Secao7TopicosEspeciais;

public class TimeSpanPratica
{
    public static void Executar()
    {
        
        TimeSpan t1 = new TimeSpan();
        TimeSpan t2 = new TimeSpan(90000);
        TimeSpan t3 = new TimeSpan(2,11,21);
        TimeSpan t4 = new TimeSpan(2,11,21,11);
        TimeSpan t5 = new TimeSpan(2,2,2,11,21,11);

        int x = TimeSpan.FromDays(2).Days;
        
        Console.WriteLine(x);
    }
}