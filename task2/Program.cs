/* Напишите программу, которая на вход принимает два числа
и проверяет является ли первое число квадратом второго*/

Console.Write("Введите число А: ");
int userNamberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int userNamberB = Convert.ToInt32(Console.ReadLine());
int square = userNamberB * userNamberB;
if (square == userNamberA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");   
}