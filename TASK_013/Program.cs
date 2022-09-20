/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number <= 99)
{
    Console.Write($"Третьей цифры нет ");
}
else if (number <= 999)
{
    int resalt = number % 10;
    {
        Console.Write($"Третья цифра заданного числа: {resalt}");
    }
}
else if (number <= 9999)
{
    int resalt = (number / 10) % 10;
    {
        Console.Write($"Третья цифра заданного числа: {resalt}");
    }
}
else if (number <= 99999)
{
    int resalt = (number / 100) % 10;
    {
        Console.Write($"Третья цифра заданного числа: {resalt}");
    }
}
else if (number <= 999999)
{
    int resalt = (number / 1000) % 10;
    {
        Console.Write($"Третья цифра заданного числа: {resalt}");
    }
}
else if (number <= 9999999)
{
    int resalt = (number / 10000) % 10;
    {
        Console.Write($"Третья цифра заданного числа: {resalt}");
    }
}
else if (number <= 99999999)
{
    int resalt = (number / 100000) % 10;
    {
        Console.Write($"Третья цифра заданного числа: {resalt}");
    }
}
else if (number <= 999999999)
{
    int resalt = (number / 1000000) % 10;
    {
        Console.Write($"Третья цифра заданного числа: {resalt}");
    }
}



/*else 
{
    Console.WriteLine("Введите число поменьше");
} */
