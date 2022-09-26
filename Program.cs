//// See https://aka.ms/new-console-template for more information

//Console.Write("Inserisci il nome dell'evento: ");
//string title = Console.ReadLine();

//Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
//string date = Console.ReadLine();

//Console.Write("Inserisci il numero di posti totali: ");
//int maxOccupancy = Convert.ToInt32 (Console.ReadLine() ?? "0");

//Event newEvent = new Event(title, date, maxOccupancy);

//Console.Write("Quanti posti desideri prenotare? ");
//int reservedSeats = Convert.ToInt32 (Console.ReadLine() ?? "0");
//newEvent.ReserveSeat(reservedSeats);

//Console.WriteLine("---------------------------------------------");

//Console.WriteLine($"Numero di posti prenotati = {newEvent.ReservedSeats}");
//Console.WriteLine($"Numero di posti disponibili = {newEvent.GetAvailableSeats()}");
//Console.WriteLine();
//string userChoice;
//do
//{
//    Console.Write("Vuoi disdire dei posti (si/no)? ");
//    userChoice = Console.ReadLine();
//    if (!string.IsNullOrEmpty(userChoice) && userChoice == "si")
//    {
//        Console.Write("Indica il numero di posti da disdire: ");
//        int userCancelSeatsChoice = Convert.ToInt32 (Console.ReadLine() ?? "0");
//        newEvent.CancelSeat(userCancelSeatsChoice);
//    } else
//    {
//        Console.WriteLine("Ok va bene!");
//    }
//    Console.WriteLine();
//    Console.WriteLine($"Numero di posti prenotati = {newEvent.ReservedSeats}");
//    Console.WriteLine($"Numero di posti disponibili = {newEvent.GetAvailableSeats()}");
//} while (userChoice == "si");

using System.Diagnostics.Tracing;
using System.Reflection.Metadata;

Console.Write("Inserisci il nome del tuo programma Eventi: ");
string programName = Console.ReadLine() ?? "" ;

Console.Write("Indica il numero di eventi da inserire: ");
 int eventsLength = Convert.ToInt32(Console.ReadLine());

ProgramEvents newEvents = new ProgramEvents(programName);

    while (newEvents.PrintListEventsCount() < eventsLength)
    {
        Event newEvent = null;
        Console.WriteLine();
        Console.Write("Inserisci il nome dell'evento: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
        string date = Console.ReadLine() ?? "";

        Console.Write("Inserisci il numero di posti totali: ");
        int totalSeats = Convert.ToInt32(Console.ReadLine() ?? "");
        try
        {
            newEvent = new Event(title, date, totalSeats);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        newEvents.AddEvent(newEvent);
        Console.WriteLine("Il riepilogo dell'evento è: " + newEvent.ToString());
    }
    


Console.WriteLine();
Console.WriteLine("Il numero di eventi nel programma è: "+ newEvents.PrintListEventsCount());
Console.WriteLine("Ecco il tuo programma eventi:");
Console.WriteLine(newEvents.ToString());

Console.WriteLine("Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy)");
string dateSearch = Console.ReadLine() ?? "";

newEvents.EventsReset();