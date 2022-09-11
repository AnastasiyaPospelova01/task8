//** доп задача
//** Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] MakeMatrix(int row, int col) {
    int[,] matrix = new int [row, col];
    for (int columns = 0; columns < col; columns++) {
        for (int rows = 0; rows < row; rows++) {
            matrix[rows,columns] = new Random().Next(1, 10);
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

int[,] ResultMatrix (int[,] matrix1, int[,] matrix2, int row, int col) {
    int[,] matrix = new int[row,col];
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
            matrix[i,j] = 0;
            for (int k = 0; k < 2; k++) {
                matrix[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return matrix;
}

int row = 2, col = 2;
int [,] matrix1 = MakeMatrix(2, 2), matrix2 = MakeMatrix(2, 2);
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);

int [,] resultMatrix = ResultMatrix(matrix1, matrix2, row, col);
Console.WriteLine("Результат перемножения матриц: ");
PrintMatrix(resultMatrix);
