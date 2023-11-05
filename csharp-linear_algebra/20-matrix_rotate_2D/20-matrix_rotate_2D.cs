﻿using System;



class Program{

    public static void Main(){

        double[,] startedPoint = { {1, 2}, { 3, 4}};
        double[,] result = MatrixMath.Rotate2D(startedPoint, -1.57);
        Console.WriteLine(result[0,0] + ": " + result[0,1] + ": " + result[1,0] + " : " + result[1,1]);

    }
}
class MatrixMath{
    public static double[,] Rotate2D(double[,] matrix, double angle){
        double[,] rotationMatrix = {
            { Math.Cos(angle), -Math.Sin(angle)},
            { Math.Sin(angle), Math.Cos(angle)}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] result = new double[rows,cols];

         for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    result[row, col] = 0;
                    for (int k = 0; k < rows; k++)
                    {
                        result[row, col] += rotationMatrix[row, k] * matrix[k, col];
                    }
                }
            }

        return result;
    }
}