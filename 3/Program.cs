// See https://aka.ms/new-console-template for more information
int day;
Console.Write("Enter the day of the week: ");
day = int.Parse(Console.ReadLine()!);
if (day == 6 || day == 7)
{
    Console.WriteLine("Yes");
}
if (day <= 5 && day != 0)
{
    Console.WriteLine("No");
}
if (day > 7)
{
    Console.WriteLine("Wrong day of the week was entered!");
}