// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello    \n  Enter your name    ");
string name = Console.ReadLine();

Console.WriteLine($"Welcome {name}" );

Random random = new Random();

int num = random.Next(1, 50);

if (num >= 20)
{
    Console.WriteLine($"TRY AGAIN");
}
else if (num <= 21)
{
    Console.WriteLine($"CONGRATULATIONS YOU WIN 100K");
}
else
{
    Console.WriteLine($"CONGRATULATIONS YOU WIN 200K");
}
