// See https://aka.ms/new-console-template for more information
int number;
Console.Write("Enter three-digit number: ");
number = int.Parse(Console.ReadLine()!);
number = number / 10 % 10;
Console.WriteLine("Second digit of entered number is: " + number);