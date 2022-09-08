// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i,j]} ");
        }
    Console.WriteLine();
    }
}



int m = 5;
int n = 6;

int[,] A = new int[m,n];

for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i,j] = m + n;
    }
}

PrintArray(A);
