/* Напишите программу, котоорая на вход принимает одно число, 
а на выходе выводит все целые числа от -N до N */

Console.Write("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int count = -namber;
while (count <= namber)
{
   Console.Write($"{count}, "); /* Знак $ выводит форматированный вывод */
   count++;
}