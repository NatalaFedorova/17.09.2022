// Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

{
    Console.WriteLine("Введите число нуля: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int num = 2;
    if (number < 1)
    {
        Console.WriteLine("Неверный ввод");
    }
    if (number == 1)
    {
        Console.WriteLine("Нет четных чисел");
    }
    else
    {
        while (num <= number)
        {
            Console.Write(num + ", ");
            num = num + 2;
        }
    }
}
