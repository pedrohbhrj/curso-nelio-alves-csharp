namespace CursoNelio.Secao7TopicosEspeciais;

public class DateTimePratica
{

    public static void Executar()
    {
        
        // instanciacoes
        // formas de construir data com date time.
        DateTime d1 = new DateTime(2026,11,05);
        DateTime d2 = new DateTime(2026,11,05,13,43,40);
        DateTime d3 = new DateTime(2026,11,05,13,43,40,999);
        DateTime d4 = DateTime.Now;
        DateTime d5 = DateTime.Today;


            
        DateTime parsingString = DateTime.Parse("2026-11-05");
        DateTime parsingStringTwo = DateTime.Parse("2026-11-05 13:05:58");
        
        
    }
}