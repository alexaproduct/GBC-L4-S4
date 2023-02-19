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

int inew = 0;
int j = 0;
int izero = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 0)
    {
        izero = izero + i;
        Console.WriteLine(izero);
        arr[j] = 0;
        j = j + 1;
        for (int y = 1; y <= izero; i++)
        {
            arr[y] = arr[y-1];
            arr[izero] = arr[izero-1];
        }
    }
    Console.Write(arr[i] + " ");
    PrintMas(arr);
}
