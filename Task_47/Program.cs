// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

//Функция генерации массива вещественными числами в заданном диапазоне
double[,] GetArrayReal(int row, int column, int minValue, int maxValue)
{
    double[,] arrayReal = new double[row,column];
    
    for (int i = 0; i < arrayReal.GetLength(0); i++)
	{
		for (int j = 0; j < arrayReal.GetLength(1); j++)
		{
			arrayReal[i,j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue,2);
        }
		
	}
    return arrayReal;
}

//Вывод 2-мерного массива на экран
void Print2sizeArray (double[,] arr)
{
	//int rows =0;
	//int columns =0;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i, j]} \t");
		}
		Console.WriteLine("]");
	}

}

Console.Clear();
//Приветствие
Console.WriteLine("Программа генерации двухмерного массива вещественных чисел");
int row = GetNumberInt("Введите количество строк массива - ");
int columns = GetNumberInt("Введите количество столбцов массива - ");
double[,] arrayRealNumbers = new double[row,columns];
arrayRealNumbers = GetArrayReal(row,columns,0,10);// генерация массива в диапазоне от 0 до 10
Print2sizeArray(arrayRealNumbers);