// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void PrintArray(int[,] matr)//вывод массива на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)//заполнение массива случайными числами

{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}

void MeanAverageNumber (int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = matr[i,j] + sum;
        }
    double length = matr.GetLength(0);
    double meanAverage = sum / length;
    Console.WriteLine("Среднее {0}-го столбца равно {1}", j+1 , meanAverage);
    }
}

int[,] matrix = new int[5, 5];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
MeanAverageNumber(matrix);