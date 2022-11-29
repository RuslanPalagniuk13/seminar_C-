/* Напишите программу, котоорая на вход принимает на вход трехзначное число 
и на выходе выходе показывает последнюю цифру этого числа */

Console.Write("Введите трехзначное число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int ostatok = namber % 10;
Console.WriteLine($"Последняя цифра {ostatok} ");