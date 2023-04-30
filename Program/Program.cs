int ReadData(string msg) 
{
    int res;
    while (true)
    {
        try
        {
            Console.Write(msg);
            res = int.Parse(Console.ReadLine()??"0");
            break; 
        }
        catch
        {
            Console.WriteLine("Нужно ввести число!");
        }
        
    }
    
    return res;
}

(string[], int) GenArrAndCountElemsLess4(int arrLength)
{
    string[] arr = new string[arrLength];
    int count = 0;
    for (int i = 0; i < arrLength; i++)
    {
        Console.Write("Введите arr[{0}]: ", i);
        arr[i] = Console.ReadLine()??"0";
        if (arr[i].Length < 4)
            count++;
    }
    return (arr, count);
}

void PrintArr(string[] arr)
{
    if (arr.Length == 0)
    {
        Console.WriteLine("[]");
        return;
    }
    Console.Write("[\""+arr[0]+"\"");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write(", \""+arr[i]+"\"");
    }
    Console.WriteLine("]");
}

string[] ReturnArrWithElemsLessLength(int count, string[] arr)
{
    string[] newArr = new string[count];
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    return newArr;
}

int n = ReadData("Введите размер массива: ");
(string[] arr, int count) = GenArrAndCountElemsLess4(n);
PrintArr(arr);
string[] newArr = ReturnArrWithElemsLessLength(count, arr);
PrintArr(newArr);