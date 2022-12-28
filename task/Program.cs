
string[] array = new string[] { "some word", "one", "Duna", "123", "45678" };

void PrintArray(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void CheckThreeChars(string[] arr)
{
       for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
        }
        else arr[i] =  string.Empty;

    }
}

PrintArray(array);
CheckThreeChars(array);
Console.Write("-> ");
PrintArray(array);