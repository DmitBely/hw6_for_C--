// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты


void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i,j]}  ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            col[i,j] = new Random().Next(1,10);
        }
    }
}

void IndxCheck(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {   
    
        for (int j = 0; j < col.GetLength(1); j++)
        {   
            int x = i;
            int y = j;
            if (((x % 2 == 0) & (y % 2 == 0)) & ((x != 0) & (y != 0)))
            {
                col[i,j] = col[i,j] * col[i,j];
            }
            else
            {
                col[i,j] = col[i,j];
            }
        }
    }
}

int a = 5;
int b = 5;

int[,] array = new int[a, b];



FillArray(array);
PrintArray(array);
Console.WriteLine();
IndxCheck(array);
PrintArray(array);