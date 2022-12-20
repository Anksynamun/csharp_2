// See https://aka.ms/new-console-template for more information
Int64 number;
string mystring;
Console.Write("Enter any number: ");
number = Int64.Parse(Console.ReadLine()!);
if (number >= 100)
{
    mystring = number.ToString();
    Console.WriteLine("Third digit of number is: " + mystring[2]);
}
else 
{
    Console.WriteLine("No third digit in given number");
}