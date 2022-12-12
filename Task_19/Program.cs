/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

void fiveNumber(string number)
{
	if (number[0] == number[4] && number[1] == number[3])
	{
		Console.WriteLine($"Число: {number} - палиндром.");
	}
	else Console.WriteLine($"Число: {number} - НЕ палиндром.");
}

if (number.Length == 5)
{
	fiveNumber(number);
}
else Console.WriteLine($"Вы ввели не пятизначное число!!!, повторите попытку");