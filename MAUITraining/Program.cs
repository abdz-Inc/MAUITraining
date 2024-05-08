// See https://aka.ms/new-console-template for more information
using MAUITraining;

User u1 = new();

try
{
    Console.Write("Enter user Id : ");
    u1.Id = Console.ReadLine();
    Console.Write("Enter user Name : ");
    u1.Name = Console.ReadLine();
    Console.Write("Enter user Ponenumber : ");
    u1.Phonenumber = Console.ReadLine();
}
catch(ArgumentException e)
{
    Console.WriteLine(e.Message);   
}