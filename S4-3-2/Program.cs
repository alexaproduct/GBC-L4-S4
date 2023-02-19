// v2

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

for (int i = 0; i < arr.Length; i++)
{
   for (int j = arr.Length-1; j >= arr.Length/2; j = j-1)
   {
    arr[i] = arr[j];
    Console.WriteLine(arr[i]);
   }
}