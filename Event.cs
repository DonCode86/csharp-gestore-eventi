// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

public class Event
{
    public string Title { get; set; }

    private DateOnly date;
    private string v1;
    private int v2;
    private int v3;
    private string? date1;

    public DateOnly Date
    {
        get => date;
        set
        {
            if ( DateOnly.FromDateTime(DateTime.Now) > date)
            {
                Console.WriteLine("La data non può essere antecedente alla data odierna!");
            }    
        }
    }
    public int MaxOccupancy { get; }
    public int ReservedSeats { get; private set; }

    public Event(string title, DateOnly date, int maxOccupancy)
    {
        Title = title;
        this.date = date;
        MaxOccupancy = maxOccupancy;
        ReservedSeats = 0;
    }

    public Event(string v1, int v2, int v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

    public Event(string? title, string? date1, int maxOccupancy)
    {
        Title = title;
        this.date1 = date1;
        MaxOccupancy = maxOccupancy;
    }

    public override string ToString()
    {
        return $"{Title} - {Date:dd/MM/yyyy}";
    }
    public void ReserveSeat(int seats)
    {
   
        if (ReservedSeats + seats > MaxOccupancy)
        {
            Console.WriteLine("Spiacente, non ci sono piu' posti liberi.");
        } else if (DateOnly.FromDateTime(DateTime.Now) < date)
        {
            Console.WriteLine("Spiacente, l'evento si e' già tenuto");
        }
        ReservedSeats += seats;
    }

    public int GetAvailableSeats()
    {
        return MaxOccupancy - ReservedSeats;
    }

    public void CancelSeat(int seats)
    {
        if(ReservedSeats == 0)
        {
            Console.WriteLine("Non ci sono posti da annullare!");
        }
        else if (date < DateOnly.FromDateTime(DateTime.Now))
        {
            Console.WriteLine("Spiacente, l'evento si e' già tenuto");
        }
        ReservedSeats -= seats;
    }
}
