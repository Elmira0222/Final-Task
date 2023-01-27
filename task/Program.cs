Console.WriteLine("Given an array of strings: ");
string[] array = {"3456", ":-)", "son",  "Astana", "==", "2(n^2)", "-4"};
for (int i = 0; i < array.Length; i++)
Console.Write(array[i] + " ");
Console.WriteLine();
Console.WriteLine("Final array: ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write(array[i] + " ");
    }
}

