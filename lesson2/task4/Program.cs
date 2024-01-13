int N = 5;
int[] arr = { 1, 2, 3, 4, 5 };
int i = 0;
int max = arr[0];

while (i < N)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine($"Максимальный вес гири = {max}");

// Далее решение этой задачи с использованием цикла 'for'

max = arr[0];
for (int j = 0; j < N; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
Console.WriteLine($"Максимальный вес гири = {max}");

// Далее решение данной задачи с использованием цикла 'foreach'

max = arr[0];
foreach(int e in arr)
{
   if (e > max)
     {
        max = e;
    }
}
Console.Write($"Максимальный вес гири = {max}");