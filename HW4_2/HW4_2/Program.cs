int SumDigits(int number)
{
    int sum = 0;

    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }

    return sum;
}

int number = 82;
int sum = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sum}");