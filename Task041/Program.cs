// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Clear();

Console.Write("Определение чисел больше 0 -> Введите числа через пробел: ");
String elements = Console.ReadLine();

int[] array = GetArrayFromString(elements);

Console.WriteLine($"[{String.Join(", ", array)}]");

Console.WriteLine($"Количество чисел больше 0 = {greaterThanZeroElement(array)} ");

int[] GetArrayFromString(string stringArray)
{
    string[] numbers = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

int greaterThanZeroElement(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}