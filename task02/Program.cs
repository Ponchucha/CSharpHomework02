/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);

Console.WriteLine ($"Найдём третью цифру числа {number}");

if (number < 0)
{
    number = number * (-1);
}

if (number < 100)
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}
else
{
    while (number >= 1000)
        {
        number = number / 10;
        }


    Console.WriteLine($"А третья цифра равна {number % 10}");
}
