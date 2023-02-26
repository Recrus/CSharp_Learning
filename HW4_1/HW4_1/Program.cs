int Power(int A, int B)
{
    int result = 1;

    for (int i = 0; i < B; i++)
    {
        result *= A;
    }

    return result;
}

// Хотя можно просто Math.Pow() использовать)
int a = 3;
int b = 5;
int result = Power(a, b);
Console.WriteLine($"{a}^{b} = {result}");