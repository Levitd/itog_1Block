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
    int i=0;
    foreach (string item in inArray){
        if (item.Length <= 3) {
            newArray[i]=item;
            i++;
        }
    }
    return newArray;
}

string[] array1 = new string[] {"sfgdb sdfgb", "fr", "advasdf", "hjjhgbkh"};

WriteLine($"[{String.Join(",",array1)}] -> [{String.Join(",", smolArray(array1))}]");