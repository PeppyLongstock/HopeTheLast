char[] s = {'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; i < count; j++)
    {
    Console.WriteLine($"{n++,-5"}{s[i]} {s[j]});
    }
}