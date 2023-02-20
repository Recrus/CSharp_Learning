int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    Console.WriteLine("Error, possibly your number is under 0");
}

for (int i = 1; i < num + 1; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}