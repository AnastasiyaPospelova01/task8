//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт
//номер строки с наименьшей суммой элементов: 1 строка

int[,] MakeMatrix(int row, int col) {
    int[,] matrix = new int [row, col];
    for (int columns = 0; columns < col; columns++) {
        for (int rows = 0; rows < row; rows++) {
            matrix[rows,columns] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix) {
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int rows = 0; rows < row; rows++) {
        for (int column = 0; column < col; column++) {
            Console.Write($"{matrix[rows, column],3}");
            }
        Console.WriteLine();
    }
}

int FindSum (int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++) {
        sum += array[i];
    }
    return sum;
}

void FindMin (int[] array) {
    int min = 100;
    int str = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] < min) {
            min = array[i];
            str = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {str+1}-я");
}

int row = 5, col = 4;
int [,] matrix = MakeMatrix(row, col);
PrintMatrix(matrix);

int[] amounts = new int[row];
for (int i = 0; i < row; i++) {
    int[] array = new int[col];
    for (int j = 0; j < col; j++) {
        array[j] = matrix[i,j];
    }
    amounts[i] = FindSum(array);
}

Console.WriteLine();
FindMin(amounts);