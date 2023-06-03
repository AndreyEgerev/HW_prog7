// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

//Вывод 2-мерного массива на экран
void Print2sizeArray (int[,] arr)
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

//Вывод 1-мерного массива на экран
void PrintArray(double[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} \t");
    }
    Console.WriteLine("]");
}

//Функция генерации массива целыми числами в заданном диапазоне
int[,] GetArrayInt(int[,] arrayInt, int minValue, int maxValue)
{
    //int[,] arrayInt = new int[row,column];
    for (int i = 0; i < arrayInt.GetLength(0); i++)
	{
		for (int j = 0; j < arrayInt.GetLength(1); j++)
		{
		 arrayInt[i,j] = new Random().Next(minValue, maxValue);
        }
		
	}
    return arrayInt;
}

//функция вычисления среднего значения по столбцам
double[] AverageSummArray (int[,] array)
{
	double[] aVGSummArray = new double[array.GetLength(1)];
	int summElement = 0;
	for (int j = 0; j < array.GetLength(1); j++)
	{
		summElement = 0;
        for (int i = 0; i < array.GetLength(0); i++)
		{
			summElement += array[i, j];
		}
        aVGSummArray[j] = Math.Round(Convert.ToDouble(summElement) / Convert.ToDouble(array.GetLength(0)), 2);//преобразовать в double элементы вычислений
	}
	return aVGSummArray;
}

Console.Clear();
//Приветствие
Console.WriteLine("Программа вычисления среднего арифметического в каждом столбце 2х-мерного массива");
int rows = GetNumberInt("Введите количество строк массива - ");
int columns = GetNumberInt("Введите количество столбцов массива - ");
int[,] arrayIntNumbers = new int[rows,columns];
arrayIntNumbers = GetArrayInt(arrayIntNumbers,0,10);//генерация 2х-мерного массива с элементамми в диапазоне от 0 до 10
Print2sizeArray(arrayIntNumbers);
double[] summArray = new double[columns];
summArray = AverageSummArray(arrayIntNumbers);
Console.WriteLine("Среднее арифметическое по столбцам - ");
PrintArray(summArray);
