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
    FillTable(tableNumbers, -10, 10);
    PrintTable(tableNumbers);
}
// task47();

void FillTable(double[,] tableNumbers, int minnumber, int maxnumber)
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

void PrintTable(double[,] tableNumbers)
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
    FillTable(tableNumbers, -10, 10);
    PrintTable(tableNumbers);
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