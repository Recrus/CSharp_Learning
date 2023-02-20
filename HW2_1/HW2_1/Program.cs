int num = Convert.ToInt32(Console.ReadLine());
while(num is < 100 or >= 1000)
{ 
    Console.WriteLine("Invalid value, prompt number with 3 digits");
    num = Convert.ToInt32(Console.ReadLine());
}

while (num >= 100)
{
    num /= 10;
}

num %= 10;

Console.WriteLine($"The middle digit is {num}");