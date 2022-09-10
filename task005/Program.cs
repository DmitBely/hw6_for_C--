// Написать программу, которая обменивает элементы первой строки и последней строки

void PrintArray(int[,] matr)
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

void FillArray(int[,] matr)

{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}

void Exchange(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {   
        int temporary = 0;
        int maxLine = matr.GetLength(0)-1;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            temporary = matr[0,j];
            matr[0,j] = matr[maxLine,j];
            matr[maxLine,j] = temporary;
        }
    }
}

int[,] matrix = new int[5,5];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Exchange(matrix);
PrintArray(matrix);