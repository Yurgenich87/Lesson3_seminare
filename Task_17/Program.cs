/*
Задача №17.Напишите программу,которая принимает на вход координаты (X и Y),причем X не равен 0 и Y не равен 0 и выдает номер четверти плоскости 
в которой находится эта точка
*/

int GetNumber(string message)
{
	bool isCorrect = false;
	int result = 0;

	while (!isCorrect)
	{
		Console.WriteLine(message);
		if (int.TryParse(Console.ReadLine(), out result) && result != 0)
		{
			isCorrect = true;
		}
		else
		{
			Console.WriteLine("Ввели некоректное число");
		}
	}
	return result;
}

int GetQuarter(int x, int y)
{
	if (x > 0 && y > 0)
		return 1;
	if (x < 0 && y > 0)
		return 2;
	if (x < 0 && y < 0)
		return 3;

	return 4;
}

int x = GetNumber("Введите координату x:");
int y = GetNumber("Введите координату y:");
int quarter = GetQuarter(x, y);


Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в {quarter} четверти");

