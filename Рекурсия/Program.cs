/*Собрать строку с числами от a до b, a <= b
*/
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = 0; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

string NumbersRec (int a, int b)
{
    if (a <= b) return $"(a)" + NumbersRec(a+1,b);
    else return String.Empty;
} 
Console.WriteLine(NumbersFor(1,10)); //123456789
Console.WriteLine(NumbersRec(1,10)); //123456789

/*Собрать строку с числами от a до b, a >= b
*/
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i}";
    }
    return result;
}

string NumbersRec (int a, int b)
{
    if (a <= b) return (a+1, b) + $"(a)";
    else return String.Empty;
} 
Console.WriteLine(NumbersFor(1,10)); //123456789
Console.WriteLine(NumbersRec(1,10)); //123456789