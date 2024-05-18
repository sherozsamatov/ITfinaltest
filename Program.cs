class Program
{
  static void Main(Strings[] args)
  {
    // Задаем начальный массив строк
    string[] initialArray = { "Hello", "2", "world", ":-)" };

    // Вызываем метод для формирования нового массива
    string[] newArray = GetNewArray(initialArray);

    // Выводим метод для формирования нового массива
    Console.WriteLine("Новый массив:");
    foreach (string str in newArray)
    {
      Console.Write(str + " ");
    }
    Console.ReadLine();

  }
  static string[] GetNewArray(string[] inputArray)
  {
    // Создаем новый временный массив для хранения элементов, длина которых меньше или равна 3 символам
    string[] tempArray = new string[inputArray.Length];
    int count = 0;

    // Проходим по каждому элементу исходного массива
    for (int i = 0; i < inputArray.Length; i++)
    {
      // Если длина элемента массива меньше или равна 3 символам, добавляем его во временный массив
      if (inputArray[i].Length <= 3)
      {
        tempArray[count] = inputArray[i];
        count++;
      }

    }
    // Создаем новый массив с нужной длиной
    string[] resultArray = new string[count];
    Array.Copy(tempArray, resultArray, count);

    return resultArray;

  }
}