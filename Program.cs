int guests = 4;
int guestsPerTable = 2;
int currentGuest = 0;

while (currentGuest < guests)
{
    for (int i = 0; i < guestsPerTable && currentGuest < guests; i++)
    {
        Console.WriteLine("Hi! What is your name?");
        string UserName = Console.ReadLine();

        Console.WriteLine($"Hi {UserName}. Your table #{(currentGuest / guestsPerTable) + 1}");
        currentGuest++;

    }

    Console.WriteLine($"Table #{(currentGuest / guestsPerTable)} is now full.");
}

Console.WriteLine("No free places");
