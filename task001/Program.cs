// Показать двумерный массив размером m×n заполненный вещественными числами

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
    Console.WriteLine("");
    }
    
}


void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}

Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];
FillArray(array);
Console.WriteLine();
PrintArray(array);
