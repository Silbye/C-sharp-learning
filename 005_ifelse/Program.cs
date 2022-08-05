Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "silbye")
{
    Console.WriteLine("This username is already taken");
}
else
{
    Console.WriteLine("Hello, " + username + ".");
}
