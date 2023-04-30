// Returns entered int
int ReadData(string msg)
{
    int res;
    while (true)
    {
        try
        {
            Console.Write(msg);
            res = int.Parse(Console.ReadLine() ?? "0");
            break;
        }
        catch
        {
            Console.WriteLine("Нужно ввести число!");
        }

    }

    return res;
}

// Method to generate array with keyboard
string[] GenArrByKeyboard(int arrLength)
{
    string[] arr = new string[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        Console.Write("Введите arr[{0}]: ", i);
        arr[i] = Console.ReadLine() ?? "0";
    }
    return arr;
}

// Prints array
void PrintArr(string[] arr)
{
    if (arr.Length == 0)
    {
        Console.WriteLine("[]");
        return;
    }
    Console.Write("[\"" + arr[0] + "\"");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write(", \"" + arr[i] + "\"");
    }
    Console.WriteLine("]");
}

// Returns number of elements with length less than elemLen in arr
int CountElemsWithLenLess(int elemLen, string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < elemLen)
            count++;
    }
    return count;
}

// Returns array with elements less than elemLen characters long in given arr
string[] ReturnArrWithElemsLenLess(int elemLen, string[] arr)
{
    int count = CountElemsWithLenLess(elemLen, arr);
    string[] newArr = new string[count];
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < elemLen)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    return newArr;
}

int n = ReadData("Введите размер массива: ");
string[] arr = GenArrByKeyboard(n);
string[] newArr = ReturnArrWithElemsLenLess(4, arr);
PrintArr(newArr);