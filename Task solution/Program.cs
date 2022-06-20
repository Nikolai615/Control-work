using System;
using static System.Console;

Console.Clear();

string[] array1 = new string[6] {"356", "ok", "victory", "GeekBrains", "res", "45"};
string[] array2 = new string[array1.Length];

ChooseElements(array1, array2);
PrintArray(array2);

void ChooseElements(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
