int num = Convert.ToInt32(Console.ReadLine());

// Вложенное условие, вероятно, не самое лучшее решение
if (num > 7)
{
    Console.WriteLine($"Are there more than 7 days in your week? I'm sorry about that...");
}
else
{
    if (num is 6 or 7)
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }
}
