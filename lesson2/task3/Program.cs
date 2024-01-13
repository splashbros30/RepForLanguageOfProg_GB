//int N = 10;
int[] arr = { 2, 5, 7, 4, 65, 135, 546, 43, 32, 13 };
int i = 0;

while (i < arr.Length)
{
    if ((arr[i] % 2) == 0)
    {
        Console.Write($"{arr[i]} ");
        i = i + 1;
    }
    else
    {
        i = i + 1;
    }
}