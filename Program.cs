/* 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
*/

string[] ScanStringArray(string[] array, int n)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n) result++;
    }
    string[] resultString = new string[result];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            resultString[j] = array[i];
            j++;
        }
    }
    return resultString;
}

string[] NewStringArray(int n)
{
    string[] result = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        result[i] = Console.ReadLine();
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
}

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] result = ScanStringArray(NewStringArray(num), 3);
Console.Write ("Массив элементов меньше или равных 3 символам: ");
PrintArray(result);