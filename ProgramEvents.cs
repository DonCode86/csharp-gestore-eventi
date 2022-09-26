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

    public void AddEvent (Event newEvent)
    {
        events.Add (newEvent);
    }

    public void GetEventByDate(DateTime date)
    {
        foreach (Event e in events)
        {
            if (e.Date == date)
            {
                Console.WriteLine(e.Title);
            } else
            {
                Console.WriteLine("Non ci sono eventi per la data richiesta.");
            }
        }
    }

    public static void PrintEvents (List<Event> events)
    {
        foreach(Event e in events)
        {
            Console.WriteLine($"Questa è la tua lista di eventi: {e.ToString}" );
        }
    }

    public int PrintListEventsCount()
    {
        return events.Count;
    }

    public void EventsReset ()
    {
        events.Clear(); 
    }
}