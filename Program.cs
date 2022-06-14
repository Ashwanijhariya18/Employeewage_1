// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage computation");
var Random = new Random();
int res = Random.Next(0, 2);
if (res == 0)
{
    Console.WriteLine("Absent");
}
else
{
    Console.WriteLine("Present");
}