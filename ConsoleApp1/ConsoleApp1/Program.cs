// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information



Console.WriteLine("Please write the number of the day");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("It is a working day");
        break;
    case 6:
    case 7:
        Console.WriteLine("It is holiday");
        break;
    default:
        Console.WriteLine("Invalid number!");
        break;
}
