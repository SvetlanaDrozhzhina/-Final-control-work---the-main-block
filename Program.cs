﻿string[] array = new string[4] {"Hello", "2", "world", ":-)"};
string[] result_array = new string[SizeCounter(array)];
LessThan3Length(array, result_array);
int SizeCounter(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            size = size + 1;
        }
    }
    return size;
}

void LessThan3Length(string[] array_1, string[] array_2)
{
    int count = 0;
    for (int i = 0; i < array_1.Length; i++)
    {
    if(array_1[i].Length <= 3)
        {
        array_2[count] = array_1[i];
        count = count + 1;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

PrintArray(result_array);