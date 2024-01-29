// Домашнее задание
// Лекция 4. Двумерные массивы
// Считать с консоли строку, состоящую из цифр и 
// латинских букв. Сформировать массив, состоящий 
// из цифр этой строки.
// Пример
// abc123def06g => [1, 2, 3, 0, 6]
// Рекомендации
// • Разделить логику алгоритма на функции
// • Память под массив выделять необходимого 
// размера (не больше, чем количество элементов)

using System;

void is_digit(string str, out string dig, out int count)
{
  dig = "";
  count = 0;
  foreach (char e in str)
  {
    if (char.IsDigit(e) == true)
    {
      dig = dig + e;
      count++;
    }
  }
}

void convert_to_array(string str, int c)
{
  char[] arr  = new char[c];
  arr = str.ToCharArray();
  int f = arr.Length - 1;
  Console.Write("[");
  for (int i = 0; i < f; i++)
  {
    Console.Write($"{arr[i]}, ");
  }
  Console.Write($"{arr[f]}");
  Console.Write("]");
}

Console.WriteLine("Введите строку для изменения: ");
string s = Console.ReadLine()!;
string dig;
int count;
is_digit(s, out dig, out count);
convert_to_array(dig, count);