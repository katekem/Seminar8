// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы.
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
Console.Clear();

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int numLine, int numColumns)
{
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)     // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Столбец
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MyArray = FillArray(row, col);
PrintArray(MyArray);

if (MyArray.GetLength(0)!= MyArray.GetLength(1))
{
    Console.WriteLine("Невозможно транспонировать");
}
else
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            Console.WriteLine("возможно транспонировать");
        }
    }
}