Console.Clear();
Console.WriteLine("Имеется следующий массив строк:");

string[] array1 = new string[] { "365", "Number", "Year", "25", "Month", "Day" };
string[] array2 = new string[array1.Length];

// Метод сортировки массива

void SortedArray(string[] array1, string[] array2)
{
  int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= 3)
    {
      array2[count] = array1[i];
      count++;
    }
  }
}

// Метод вывода результата

void PrintArray(string[] array)
{

  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

PrintArray(array1);
SortedArray(array1, array2);
Console.WriteLine();
Console.WriteLine("Новый массив из строк: ");
PrintArray(array2);
