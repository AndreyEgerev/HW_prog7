// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

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

//возврат значения из массива по заданной позиции
int FindElementNsizeArray(int[,] array, int i, int j)
{
	int elementNsizeArray = array[i,j];
	return elementNsizeArray;
}

//возврат есть заданный элемен в массиве или нет
bool ExistElement2sizeArray(int[,] array, int i, int j)
{
	bool existElement = false;
	if (0 <= i && 0 <= j && i < array.GetLength(0) && j < array.GetLength(1))
	{
		existElement = true;
    }	
    return existElement;
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
//Задание размера 2х-мерного массива
const int rows = 3;
const int columns = 4;

int[,] arrayIntNumbers = new int[rows,columns];
arrayIntNumbers = GetArrayInt(arrayIntNumbers,0,10);//генерация 2х-мерного массива с элементамми в диапазоне от 0 до 10
//Приветствие
Console.WriteLine("Программа поиска элемента в двухмерном массиве");
int row = GetNumberInt("Введите номер строки - ")-1;
int column = GetNumberInt("Введите номер столбца - ")-1;
Print2sizeArray(arrayIntNumbers);
if (ExistElement2sizeArray(arrayIntNumbers, row, column))
{
	Console.WriteLine($"Искомый элемент массива - {FindElementNsizeArray(arrayIntNumbers,row,column)}");
}
else
{
	Console.WriteLine("Такого элемента не существует");
}