// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

{
    Console.WriteLine("Введите число от 1 до 7");
    int number = Convert.ToInt32(Console.ReadLine());
    int [] weekday = {1, 2, 3, 4, 5};
    int [] weekend = {6, 7};
    if (weekday.Contains(number))
    {
        Console.WriteLine("Нет, не выходной(");
    }
    else if (weekend.Contains(number))
    {
        Console.WriteLine("Да, выходной)");
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}

