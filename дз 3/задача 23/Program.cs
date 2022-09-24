// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Таблица кубов всех чисел от 0 до " + number);
    if (number == 0)
    {
        Console.WriteLine("0 в кубе = 0 ");
    }
    else 
    {
        for (int i = 1; i <= Math.Abs(number); i++)
        {
            if (number > 0)          
            {
                Console.WriteLine($"{i} в кубе = {Math.Pow(i, 3)}");
            }
            else 
            {
                Console.WriteLine($"{-i} в кубе = {Math.Pow(-i, 3)}");
            }           
        }  
    }      
}
