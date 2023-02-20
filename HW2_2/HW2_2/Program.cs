try
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 100 || num > int.MaxValue)
    {
        Console.WriteLine("Your number doesn't have 3 digits");
    }
    else
    {
        while (num >= 1000)
        {
            num /= 10;
        }
        num %= 10;
        Console.WriteLine($"Third digit in your number is {num}");
    }
}
catch
{
    Console.WriteLine("Your number is too big");
}
