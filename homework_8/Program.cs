// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Task54()
{
    int row = 4;
    int column = 5;
    int[,] numbers = new int[row, column];
    FillTableInt(numbers);
    PrintTableInt(numbers);
    Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        int indexMax = i;
        for (int j = 0; j < column; j++)
        {
            int max = numbers[i, j];
            for (int k = j +1; k < column; k++)
            {
                if (numbers[i, k] > max)
                {
                    max = numbers[i, k];
                    indexMax = k;
                    (numbers[i, j], numbers[i, k]) = (numbers[i, k], numbers[i, j]);
                }
            }
        }
    }
    PrintTableInt(numbers);
}

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




Task54();
