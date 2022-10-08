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
task47();

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