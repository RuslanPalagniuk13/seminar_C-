/* Напишите программу, которая на вход принимает число и выдает его квадрат (число умножает на само себя) 
Например:
4 -> 16
3 -> 9
7 -> 49
*/

Console.WriteLine("Введите значение: ");
int userNamber = Convert.ToInt32(Console.ReadLine()); /* присвоение значения */
int result = userNamber * userNamber;
Console.WriteLine($"Квадрат числа {userNamber} равен {result}");