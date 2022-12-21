using System;
using static System.Console;

Clear();

string[] smolArray(string[] inArray)
{
    int countSmolString = 0;
    foreach (string item in inArray)
    {
        countSmolString += (item.Length <= 3) ? 1 : 0;
    }
    string[] newArray = new string[countSmolString];
    int i = 0;
    foreach (string item in inArray)
    {
        if (item.Length <= 3)
        {
            newArray[i] = item;
            i++;
        }
    }
    return newArray;
}



string[] array1 = new string[] { "Программа", "выделяет", "массивы", "из", "3-х", "и менее", "символов" };
string[] array2 = new string[] { "Hello", "2", "world", ":)" };
string[] array3 = new string[] { "1234", "1567", "-2", "computer scince" };
string[] array4 = new string[] { "Russia", "Denmark", "Kazan" };

object[] objectArrays = new object[] { array1, array2, array3, array4 };

foreach (string[] item in objectArrays)
{
    WriteLine($"[{String.Join(", ", item )}] ->[{String.Join(", ", smolArray(item))}]"); //
}



