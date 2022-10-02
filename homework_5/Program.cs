// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void Task34()
{
int size = 10;
int[] numbers = new int[size];
Fillarray(numbers, 100, 999);
Printarray(numbers);
Console.WriteLine($"В массиве {CountEvenNumbers(numbers)} чисел четные");
}

// Task34();

void Fillarray (int[] numbers, int startValue = -10, int endValue = 10)
{
    endValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(startValue, endValue);
    }
}

void Printarray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    { 
        Console.Write(numbers[i] + "  ");
    }
Console.WriteLine();
}

int CountEvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    return count;
}


// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Task36()
{
int size = 10;
int[] numbers = new int[size];
Fillarray(numbers);
Printarray(numbers);
Console.WriteLine($"Сумма элементов с нечетными индексами = {SumNumbersWithOddIndex(numbers)}");
}
// Task36();

int SumNumbersWithOddIndex(int[] numbers)
{
    int sum = 0;
    for(int i = 1; i < numbers.Length; i = i + 2)
    {
        sum += numbers[i];
    }
    return sum;
}

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95

void Task38()
{
    int size = 10;
double[] numbersDouble = new double[size];
FillarrayDouble(numbersDouble);
PrintarrayDouble(numbersDouble);
Console.WriteLine("Максимальное значение = " + FindMaxNumber(numbersDouble));
Console.WriteLine("Минимальное значение = " + FindMinNumber(numbersDouble));
Console.WriteLine($"Разница = {FindMaxNumber(numbersDouble) - FindMinNumber(numbersDouble)}");
}
// Task38();

void FillarrayDouble (double[] numbersDouble)
{
    Random random = new Random();
    for (int i = 0; i < numbersDouble.Length; i++)
    {
        numbersDouble[i] = random.NextDouble();
    }
}

void PrintarrayDouble(double[] numbersDouble)
{
    for (int i = 0; i < numbersDouble.Length; i++)
    { 
        Console.Write(numbersDouble[i] + "  ");
    }
    Console.WriteLine();
}

double FindMaxNumber(double[] numbersDouble)
{
    double maxnumber = numbersDouble[0];
    for (int i = 0; i < numbersDouble.Length; i++)
    {
        if (numbersDouble[i] > maxnumber)
        maxnumber = numbersDouble[i];
    }
    return maxnumber;
}
double FindMinNumber(double[] numbersDouble)
{
    double minnumber = numbersDouble[0];
    for (int i = 0; i < numbersDouble.Length; i++)
    {
        if (numbersDouble[i] < minnumber)
        minnumber = numbersDouble[i];
    }
    return minnumber;
}