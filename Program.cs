// See https://aka.ms/new-console-template for more information

Console.Write("Inserisci il nome dell'evento: ");
string title = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
string date = Console.ReadLine();

Console.Write("Inserisci il numero di posti totali: ");
int maxOccupancy = Convert.ToInt32 (Console.ReadLine() ?? "0");

Event newEvent = new Event(title, date, maxOccupancy);

Console.Write("Quanti posti desideri prenotare? ");
int reservedSeats = Convert.ToInt32 (Console.ReadLine() ?? "0");
newEvent.ReserveSeat(reservedSeats);

Console.WriteLine("---------------------------------------------");

Console.WriteLine($"Numero di posti prenotati = {newEvent.ReservedSeats}");
Console.WriteLine($"Numero di posti disponibili = {newEvent.GetAvailableSeats()}");
Console.WriteLine();
string userChoice;
do
{
    Console.Write("Vuoi disdire dei posti (si/no)? ");
    userChoice = Console.ReadLine();
    if (!string.IsNullOrEmpty(userChoice) && userChoice == "si")
    {
        Console.Write("Indica il numero di posti da disdire: ");
        int userCancelSeatsChoice = Convert.ToInt32 (Console.ReadLine() ?? "0");
        newEvent.CancelSeat(userCancelSeatsChoice);
    } else
    {
        Console.WriteLine("Ok va bene!");
    }
    Console.WriteLine();
    Console.WriteLine($"Numero di posti prenotati = {newEvent.ReservedSeats}");
    Console.WriteLine($"Numero di posti disponibili = {newEvent.GetAvailableSeats()}");
} while (userChoice == "si");
