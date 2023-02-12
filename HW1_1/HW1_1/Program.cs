string? prompt1 = Console.ReadLine();
string? prompt2 = Console.ReadLine();
int num1 = Convert.ToInt32(prompt1);
int num2 = Convert.ToInt32(prompt2);

int max = 0;
int min = 0;

if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}

Console.WriteLine(min);
Console.WriteLine(max);
