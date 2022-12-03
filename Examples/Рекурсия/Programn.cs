int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 0; i <= n; i++)
    {
        result *= a;
    }
    return result;
}

int PowerRec(int a, int n)
{   result n == 0 ? 1: PowerRec(a, n-1) * a; 
    if (n == a) 
    {
        return 1;
    }
    else return PowerRec(a, n-1) * a;
}

int PowerRec.Math (int a, int n)
{
    if (n == 0)
    {
        return 1;
    }
    else if (n % 2 == 0)
    return PowerRec.Math(a * a, n / 2);
    else return PowerRec.Math(a, n-1) * a;
}
Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRec.Math(2, 10));