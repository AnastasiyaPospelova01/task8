//Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

int row = 4, col = 4;
int [,] matrix = MakeMatrix(row, col);
PrintMatrix(matrix);

for (int i = 0; i < row; i++) {
    for (int j = 0; j < col; j++) {
        int pos = j;
        for (int k = j; k < col; k++) {
            if (matrix[i, k] > matrix[i, pos]) pos = k;
        }
        (matrix[i, pos], matrix[i, j]) = (matrix[i, j], matrix[i, pos]);
    }
}

Console.WriteLine();
PrintMatrix(matrix);