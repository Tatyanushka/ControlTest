using System;
using System.Linq;
Console.Clear();

string[] firstStringArray = StartArray(0);

int lengthResultArray = 0;
for (int firstIndex = 0; firstIndex < firstStringArray.Length; firstIndex++)
{
    if (firstStringArray[firstIndex].Length <= 3)
    {
        lengthResultArray=lengthResultArray+1;
    }
}

string[] resultStringArray = new string[lengthResultArray];
for (int firstIndex = 0, resultIndex = 0; firstIndex < firstStringArray.Length; firstIndex++)
{
    if (firstStringArray[firstIndex].Length <= 3)
    {
        resultStringArray[resultIndex] = firstStringArray[firstIndex];
        resultIndex=resultIndex+1;
    }
}

Console.WriteLine("Исходный массив:");
Console.WriteLine(PrintArray(firstStringArray));
Console.WriteLine();
Console.WriteLine("Результат:");
Console.WriteLine(PrintArray(resultStringArray));

string[] StartArray(int numberArray)
{
    if (numberArray == 1)
    {
        return new string[] { "numb", "212", "world", ":-*","657478un","world" };
    }
    else if (numberArray == 2)
    {
        return new string[] { "567", "1567", "-2", "computer", "^8)$" };
    }
    else if (numberArray == 3)
    {
        return new string[] { };
    }
    else
    {
        string[] array = new string[new Random().Next(0, 10)];
        for (int i = 0; i < array.Length; i++)
        {
            char simbol = Convert.ToChar(new Random().Next(Convert.ToInt32('a'), Convert.ToInt32('z') + 1));
            array[i] = new string(simbol, new Random().Next(1, 10));
        }
        return array;
    }
}

string PrintArray(string[] array)
{
    string output = "[ ";

    for (int i = 0; i < array.Length; i++)
    {
        output += array[i];
        if (i < array.Length - 1)
        {
            output += ", ";
        }
    }
    output += " ]";

    return output;
}