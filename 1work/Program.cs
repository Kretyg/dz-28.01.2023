//Составить частотный словарь элементов двумерного массива
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

//Пример: Есть набор данных

//{ 1, 9, 9, 0, 2, 8, 0, 9 }

//частотный массив может быть представлен так:

//0 встречается 2 раза
//1 встречается 1 раз
//2 встречается 1 раз
//8 встречается 1 раз
//9 встречается 3 раза
/*
int[] num = new int[10]{0,1,2,3,4,5,6,7,8,9};
int[] count = new int[10];
int[] array = new int[20];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($" {array[i]} ");
}
for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < array.Length; j++)
    {
            if (array[j] == num[i])
                 count[i]++;
  
    }

}
System.Console.WriteLine();
for (int i = 0; i < num.Length; i++)
{
    System.Console.WriteLine($" Число {num[i]} было в массиве столько раз {count[i]}");
}
*/

//Если набор данных - таблица

//1, 2, 3
//4, 6, 1
//2, 1, 6

//на выходе ожидаем получить

//1 встречается 3 раза
//2 встречается 2 раз
//3 встречается 1 раз
//4 встречается 1 раз
//6 встречается 2 раза

int[] num = new int[10]{0,1,2,3,4,5,6,7,8,9};
int[] count = new int[10];
int[,] arr = NewArray(3,5,0,10);

PrintArray(arr);

for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            if (arr[j,k] == num[i])
                    count[i]++;
        }
    }
}

for (int i = 0; i < num.Length; i++)
{
    System.Console.WriteLine($" Число {num[i]} было в массиве столько раз {count[i]}");
}

void PrintArray<T>(T[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] NewArray(int column, int row, int min, int max)
{
    int[,] arr = new int[column, row];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    return arr;
}
