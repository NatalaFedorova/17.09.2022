// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
// округлёнными до одного знака.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void task47()
{
    int row = 5;
    int column = 10;
    double[,] tableNumbers = new double [row, column];
    FillTableDouble(tableNumbers, -10, 10);
    PrintTableDouble(tableNumbers);
}
// task47();

void FillTableDouble(double[,] tableNumbers, int minnumber, int maxnumber)
{
    maxnumber++;
    maxnumber = maxnumber*10;
    minnumber = minnumber*10;
    Random random = new Random();
    for(int i = 0; i < tableNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < tableNumbers.GetLength(1); j++)
        {
            tableNumbers[i,j] = random.Next(minnumber, maxnumber)/10.0;
        }
    }
}

void PrintTableDouble(double[,] tableNumbers)
{
    for(int i = 0; i < tableNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < tableNumbers.GetLength(1); j++)
        {
            Console.Write(tableNumbers[i, j] + "\t");
        }
    Console.WriteLine();
    }
}

// Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

void task50()
{
    // Задача 47. Создать двумерный массив
    int row = 3;
    int column = 6;
    double[,] tableNumbers = new double [row, column];
    FillTableDouble(tableNumbers, -10, 10);
    PrintTableDouble(tableNumbers);
    // Создать метод поиска элемента по индексу
    CheckNumberInTable(tableNumbers);
}
// task50();

void CheckNumberInTable(double[,] tableNumbers)
{
    Console.WriteLine("Ведите индексы элемента в массиве");
    int number = Convert.ToInt32(Console.ReadLine());
    int i = number / 10;
    int j = number % 10;
    if ( i >= tableNumbers.GetLength(0) || j >= tableNumbers.GetLength(1))
    {
        Console.WriteLine($"Элемента с индексом({i},{j}) нет в массиве");
    }
    else 
    {
        Console.WriteLine($"Число с индексами ({i},{j}) это {tableNumbers[i,j]}");
    }
}

// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void task52()
{
    int row = 3;
    int column = 6;
    int[,] tableIntNumbers = new int[row, column];
    double[] middleSum = new double [column];
    FillTableInt(tableIntNumbers);
    PrintTableInt(tableIntNumbers);
    MiddleSumInColumn(tableIntNumbers, middleSum);
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    PrintArray(middleSum);
}
// task52();

void FillTableInt(int[,] tableNumbers, int minnumber = 0, int maxnumber = 10)
{
    maxnumber++;
    Random random = new Random();
    for(int i = 0; i < tableNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < tableNumbers.GetLength(1); j++)
        {
            tableNumbers[i,j] = random.Next(minnumber, maxnumber);
        }
    }
}
void PrintTableInt(int[,] tableNumbers)
{
    for(int i = 0; i < tableNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < tableNumbers.GetLength(1); j++)
        {
            Console.Write(tableNumbers[i, j] + "\t");
        }
    Console.WriteLine();
    }
}

void MiddleSumInColumn(int[,] tableNumbers, double[] middleSum)
{
    for (int j = 0; j < tableNumbers.GetLength(1); j++)
    {
        middleSum[j] = 0;
        int sum = 0;
        for (int i = 0; i < tableNumbers.GetLength(0); i++)
        {
            sum += tableNumbers[i, j];
        }
        middleSum[j] = Math.Round( sum / Convert.ToDouble (tableNumbers.GetLength(0)), 2);
    }
}

void PrintArray(double[] middleSum)
{
    for (int j = 0; j < middleSum.Length; j++)
    {
        Console.Write(middleSum[j] + "\t");
    }
    Console.WriteLine();
}

