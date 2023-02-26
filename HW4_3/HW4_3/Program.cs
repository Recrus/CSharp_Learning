void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i != arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] arr1 = {1, 2, 5, 7, 19};
PrintArray(arr1);

int[] arr2 = {6, 1, 33};
PrintArray(arr2);