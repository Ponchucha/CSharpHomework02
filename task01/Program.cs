/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Random randomVar = new Random();
int number = randomVar.Next (100,1000);

Console.WriteLine ($"Берём число {number} и смотрим, какая цифра в нём вторая?");

int secondDigit = ((number % 100) / 10);

Console.WriteLine ($"Точно! Это же {secondDigit}!");