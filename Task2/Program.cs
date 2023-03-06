// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];    // создаем массив, кот. будем возвращить наружу
    Random rnd = new Random();      // создание генератора случайных чисел
    // цикл заполнения результирующего массива случайными числами из диапазона между minValue и maxValue
    for (int i = 0; i < result.Length; i++) // инициализируем i (индекс) для первог элемента массива, пока этот индекс будет меньше длины массива, будет крутить цикл, в конце цикла увелисим i на 1
    {
        result[i] = rnd.Next(minValue, maxValue + 1);    // присваиваем случайное число элементу массива
    }
    return result;  // возвращаем массив из функции
}

// функция вывода массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int SumEvenDigits(int[] array)  // метод считает четные числа
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)  // перебор четных элементов массива
    {
        sum += array[i];
    }
    return sum;       // возвращаем сумму четных элементов массива 
}

int size = 4;
int minValue = -99;
int maxValue = 100;

int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
int sumEven = SumEvenDigits(myArray);
System.Console.WriteLine($"Сумма четных элементов массива равна {sumEven}");