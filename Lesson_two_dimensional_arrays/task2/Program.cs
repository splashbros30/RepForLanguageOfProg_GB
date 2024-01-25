int[,] CreateMatrix(int row_count, int colums_count)
{
    int[,] matrix = new int[row_count, colums_count];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10, 101);
        }
    }
    return matrix;
}

void show_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void even_numbers_in_matrix(int[,] matrix)
{
    int x = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int y = matrix[i, j];
            while (y > 0)
            {
                x = x + (y % 10);
                y = y / 10;
            }
            if (x % 2 == 0)
            {
                Console.WriteLine($"Чётное число из массива => {matrix[i, j]}");
            }
            x = 0;
        }
    }
}

int[,] Matrix = CreateMatrix(3, 3);
show_matrix(Matrix);
even_numbers_in_matrix(Matrix);
