// Дан одномерный массив целых чисел. 
// Найдите, сколько раз в нем 
// повторяется самое частое число.
// Например, 15 23 14 23 17 23 21 14 -> 3


void FillMas (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(0, 5);
        arr[i] = num;
    }
}

 void PrintMas (int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите размерность массива: ");
int k = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[k];
FillMas(arr);
PrintMas(arr);

int FindNumber(int[] arr)
{
    int result = 1;
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        count = 1;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if(arr[i] == arr[j])
            {
                count++;
                if (count > result) result = count;
            }
        }
    }
    return result;
}
Console.WriteLine(FindNumber(arr));