// Задача 64: Задайте значения M и N. 
// Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
void Task64()
{
int m = InputNomber("Введите натуральное число M");
int n = InputNomber("Введите натуральное число N");
if (m > n)
{
    (m, n) = (n, m);
}
Console.WriteLine($"M = {m}, N = {n}");
Console.Write("Натуральные числа, кратные 3 => ");
FindNumbersDividingTree(m, n);
Console.WriteLine(); 
}

int InputNomber(string input = "Введите число")
{
    Console.WriteLine(input);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindNumbersDividingTree(int m, int n, int count = 0)
{
    if (m >= n)
    {
        if (count == 0)
        {
            Console.Write("нет чисел, кратных 3");
        }
        return;
    }  
    if (m % 3 == 0)
    {
        Console.Write($"{m} ");
        count++;  
    }
    m++;
    FindNumbersDividingTree(m, n, count);
}





// Task64();
