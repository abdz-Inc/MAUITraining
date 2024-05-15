// See https://aka.ms/new-console-template for more information
using MAUITraining;

Users users = new Users();
string option;
bool exit = false;
while (!exit)
{

    Console.WriteLine("1 - Add new User");
    Console.WriteLine("2 - Display Users");
    Console.WriteLine("3 - Exit");
    Console.Write("Enter an Option : ");

    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            User u1 = new();
            try
            {

                Console.Write("Enter user Id : ");
                u1.Id = Console.ReadLine();

                Console.Write("Enter user Name : ");
                u1.Name = Console.ReadLine();

                Console.Write("Enter user Phonenumber : ");
                u1.Phonenumber = Console.ReadLine();

                Console.WriteLine("Are you an Admin?(if yes enter 'y') : ");
                if (string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase))
                {
                    u1.Type = UserType.Admin;
                }
                else
                {
                    u1.Type = UserType.NormalUser;
                }

                Console.WriteLine("User Created Successfully!");
                Console.WriteLine(u1.ToString());
                Console.WriteLine();

                users.addUser(u1);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine("User Not Created");
            }

            break;

        case "2":
            Console.WriteLine();
            users.displayUsers();
            break;


        case "3":
            exit = true;
            Console.WriteLine("Exiting program...");
            break;

        default:
            Console.WriteLine();
            Console.WriteLine("Enter a Valid Option");
            
            break;
    }
}