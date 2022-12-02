/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число от 1 до 7");
string numberStr = Console.ReadLine()??"";
int number = int.Parse(numberStr);

if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine("Это рабочий день");
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Ура! Выходной!");
    }
    else
    Console.WriteLine("Такого дня недели нет");
}



