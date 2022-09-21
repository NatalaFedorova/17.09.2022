// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 3267432979 -> 6

{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100)
    {
        Console.WriteLine("Третьей цыфры нет");
    }
    else
    {
         while (number > 999)
        {
            number = number / 10;
        }
        int numberthree = number % 10;
        Console.WriteLine("Третья цыфра " + numberthree);
    }
}
