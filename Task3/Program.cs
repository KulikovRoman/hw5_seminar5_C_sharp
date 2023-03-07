// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

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

int MinDigits(int[] array)  // метод вычичляет минимальное значение массива
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)  // перебор элементов массива
    {
        if (min < array[i])
        {
            min = min;
        }
        else
        {
            min = array[i];
        }
    }
    return min;
}

int MaxDigits(int[] array)  // метод вычичляет максимальное значение массива
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)  // перебор элементов массива
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

int size = 4;
int minValue = 0;
int maxValue = 100;

int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
int minDigits = MinDigits(myArray);
System.Console.WriteLine($"Минимальное значение массива {minDigits}");
int maxDigits = MaxDigits(myArray);
System.Console.WriteLine($"Минимальное значение массива {maxDigits}");
int sumDigits = minDigits + maxDigits;
System.Console.WriteLine($"Сумма минимального и максимального элементов массива равна {sumDigits}");