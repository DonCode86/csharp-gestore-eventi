// See https://aka.ms/new-console-template for more information
public class ProgramEvents
{
    private string title { get; set; }

    private List<Event> events;

    public ProgramEvents(string title)
    {
        this.title = title;
        events = new List<Event>();
    }
}