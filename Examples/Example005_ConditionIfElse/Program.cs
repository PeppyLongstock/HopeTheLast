Console.Write("Enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Wow! It is MASHA!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}