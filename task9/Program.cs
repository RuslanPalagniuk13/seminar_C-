/* Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и
показывает наибольшую цифру числа
например
78-> 8
12 -> 2
85 -> 8
 */

int getRandomNumberFromRenge(int minBorder, int maxBorder) /* Взять рандоное значение из диапазона */
{
    int result = new int ();
    result = new Random().Next(minBorder,maxBorder + 1);
    return result;
}
int getMaxDigitFromNumber (int number) /* Получить максимальную цифру из номера */
{
    int maxDigit = 0;
    while(number > 0)
    {
        int currentDigit = number % 10;
        if(maxDigit < currentDigit)
        {
            maxDigit = currentDigit;
        }
        Console.WriteLine(number);
        number = number / 10;
    }
    return maxDigit;
}
int getMaxDigitFromNumberOfTwoDigit(int namber)
{
    int maxDigit = namber % 10;
    int secondDigit = namber / 10;
    if (maxDigit < secondDigit)
    {
        maxDigit = secondDigit;
    }
    return maxDigit; /* оператор return завершает выполнение функции и возвращает на новый круг (выполнение возобновляется) */
}
int randomNumber = getRandomNumberFromRenge(10,99);
Console.WriteLine($"Случайное значение {randomNumber}");
int maxDigit = getMaxDigitFromNumber(randomNumber);
Console.WriteLine($"Для числа {randomNumber} большая цифра {maxDigit}");