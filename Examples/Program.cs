using System.Link;

string text = "(1,2) (2,3) (4,5) (6,7)";

var data = text.Split(" ");

for (int i = 0; i < data.length; i++)
{
    Console.WriteLine(data[i]);
}
