// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

// функция возвращает количество четных элементов
int countEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)    // определение четности элемента массива
        {
            count++;
        }
    }
    return count;
}

int size = 5;
int minValue = 100;
int maxValue = 999;
int[] array = GenerateArray(size, minValue, maxValue);
PrintArray(array);
int sumEven = countEvenNumber(array);
System.Console.WriteLine($"Количество четных элементов массива равно {sumEven}");
System.Console.WriteLine($"Количество нечетных элементов массива равно {array.Length - sumEven}");
