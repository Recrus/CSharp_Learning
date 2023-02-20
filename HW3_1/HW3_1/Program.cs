void isPalindrome(int n)
{
    int num = n;
    int numCopy = num; 
    int res = 0;
    
    if (num > 10000 && num < 100000)
    {
        while (num > 0)
        {
            res = res * 10 + num % 10;
            num /= 10;
        }

        if (res == numCopy)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
    else
    {
        Console.WriteLine("Error");
    }
}

isPalindrome(Convert.ToInt32(Console.ReadLine()));