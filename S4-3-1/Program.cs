// Задан список фамилий брокеров 
// товарной биржи из N человек. 
// Обменяйте местами фамилии брокеров: 
// первого и последнего, 
// второго и предпоследнего, 
// третьего от начала и третьего от 
// конца и т.д.
// Например, Олег Вася Камила Дора -> 
// Дора Камила Вася Олег


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


void PrintMasString(string[] arr)
{
    foreach (var item in arr)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

string s = Console.ReadLine()??"";
string[] names = s.Split(" ");

PrintMasString(names);

for (int i = 0; i < names.Length/2; i++)
{
    string temp = names[i];
    names[i] = names[names.Length - 1 - i];
    names[names.Length - 1 - i] = temp;
}

PrintMasString(names);