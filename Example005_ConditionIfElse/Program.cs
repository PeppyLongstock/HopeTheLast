Console.Write("Enter a username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Happy to see you, Masha!");
}
else
{
    Console.Write("Hi ");
    Console.WriteLine(username);
}