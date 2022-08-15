/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string textNumber = Convert.ToString(number);
if (number < 100000 && number > 9999)
    if (textNumber[0] == textNumber[4] && textNumber[1] == textNumber[3]) Console.WriteLine($"{number} является палиндромом ");
    else Console.WriteLine($"{number} не является палиндромом ");
else Console.WriteLine("Вы ввели не пятизначное число, попробуйте заново ");