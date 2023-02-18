// Задача 30: Напишите программу, 
//которая выводит массив 
//из 8 элементов, 
//заполненный нулями и единицами
//случайном порядке
// [1,0,1,1,0,1,0,0]

// Вариант 1

//int[] arr = new int[16];

//for (int i = 0; i <= 15; i++)
//{
//    arr[i] = new Random().Next(0, 2);
//    Console.WriteLine(arr[i]);
//}
//Console.WriteLine();

// Вариант 2

void FillMas (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(2); //[0 2) -> [0;1]
        arr[i] = num;
    }
}
 // 0 0 1 1 1 0 1

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

// Макс количество единиц в массиве подряд

int group = 1;
int groupmax = 0;

for(int i = 0; i < arr.Length-1; i++)
{
    if (arr[i]+arr[i+1] == 2)
    {
        group = group + 1;
        groupmax = group;
    }
    else if (arr[i]+arr[i+1] == 1) group = 1;
    else if (arr[i]+arr[i+1] == 0) group = 0;
}

if (groupmax > 1) Console.WriteLine(groupmax);
else if (groupmax == 0 && group == 1) Console.WriteLine(group);
else if (groupmax == 0 && group == 0) Console.WriteLine(0);
