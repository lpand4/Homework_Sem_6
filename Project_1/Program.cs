// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetNumbers(string message)
{
    Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountOfPositiveDigit(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

int[] arrDigit = GetNumbers("Введите количество чисел, которые будете вводить: ");
int countDigit = CountOfPositiveDigit(arrDigit);
Console.WriteLine($"Количество положиельных чисел равно {countDigit}");