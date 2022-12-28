// Final work of a GeekBrains student Danilov O.P. for 1 semester

string[] stringarray = { "hello", "2", "world", ":-)" };
int arrayLenght = stringarray.Length;
string[] stringarray2 = new string[arrayLenght];
int index2 = 0;

for (int index = 0; index < arrayLenght; index++)
{
    if (stringarray[index].Length < 4)
    {
        stringarray2[index2] = stringarray[index];
        index2++;
    }
}


void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}