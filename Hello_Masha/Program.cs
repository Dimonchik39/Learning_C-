Console.Write("Что ты такое: ");
String username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Эгэгэй, ведь это у нас Мария");
}
else
{
    Console.WriteLine("Просто привет, ");
    Console.WriteLine(username);
}
