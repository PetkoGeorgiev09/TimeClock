using TimeClock;

Console.WriteLine("Добави час (1-24):");
int hours = int.Parse(Console.ReadLine());
Console.WriteLine("Добави минути (00-59):");
int minutes = int.Parse(Console.ReadLine());
Console.WriteLine("Добави секунди (00-59):");
int seconds = int.Parse(Console.ReadLine());

Time time = new Time(hours, minutes, seconds);

time.ShowTime();

