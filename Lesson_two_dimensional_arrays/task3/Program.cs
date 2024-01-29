// Задача №3
// Лекция 4. Двумерные массивы
// Считать с консоли строку, состоящую из 
// цифр и латинских букв.
// Сформировать новую строку, состоящую из 
// букв исходной строки.

string get_letters_from_string(string str)
{
  string let = "";
  foreach (char e in str)
  {
    if ((char.IsLetter(e) == true))
    {
      let = let + e;
    }
  }
  return let;
}

Console.WriteLine("Введите строку: ");
string a = Console.ReadLine()!;
string res = get_letters_from_string(a);
Console.WriteLine("Только буквы в ведённой строке: ");
Console.WriteLine(res);