// Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем
// все остальные.
// -1 -3 -1 -3 -1 0 -4 -2 -> 0 -3 -1 -3 -1 -1 -4 -2 ; 0 -1 -3 -1 -3 -1 -4 -2


void FillMas (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(-5, 5);
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

int j = 0;

while (arr[j] == 0)
{
    j++;
}

for (int i = j; i < arr.Length; i++)
{
    if (arr[i] == 0)
    {
        for (int y = i; y > j; y--)
        {
            arr[y] = arr[y - 1];
        }
        arr[j] = 0;
        j += 1;
        PrintMas(arr);
    }
}
