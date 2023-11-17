using System;

public class MatrixTransformation
{

    public static double[,] Shear2D(double[,] matrix, char direction, double factor){
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] mMatrix;
        double[,] result = new double[rows, cols];

        if(rows != 2 || cols != 2){
            return new double[,]{ {-1}};
        }


        if(direction != "x"  || direction != "y"){
            return new double[,] { { -1}};
        }
        

        // create matrix 
        if(direction == "x"){
            mMatrix = new double[,]{ 
                { 1, 0},
                { factor, 1}
        };
        }

        if(direction == "y"){
            mMatrix = new double[,]{
                { 1, factor},
                { 0, 1}
            };
        }

        for(int i = 0; i < rows; i++){

                for(int j = 0; j < cols; j++){
                  
                  for(int u = 0; u < 2; u++){
                        result[i,j] += matrix[i, u] * mMatrix[u, j];
                }
            }
        }

        return result;

    }

    /*
    // Applies a shear along the X-axis to a 2D matrix of points.
    public static double[,] ShearX(double[,] matrix, double shx)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = matrix[i, j];
                double y = i; // Assuming each row corresponds to a Y coordinate
                // Applying shear transformation
                result[i, j] = x + shx * y;
            }
        }

        return result;


    }

    // Applies a shear along the Y-axis to a 2D matrix of points.
    public static double[,] ShearY(double[,] matrix, double shy)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = j; // Assuming each column corresponds to an X coordinate
                double y = matrix[i, j];
                // Applying shear transformation
                result[i, j] = shy * x + y;
            }
        }

        return result;
    }*/
}


/*
class Program
{
    static void Main()
    {
        double[,] matrix = {
            { 1, 2 },
            { 3, 4 }
        };

        double shearFactorX = 2; // Shear along X-axis
        double shearFactorY = 2; // Shear along Y-axis

        double[,] shearedMatrixX = MatrixTransformation.ShearX(matrix, shearFactorX);
        double[,] shearedMatrixY = MatrixTransformation.ShearY(matrix, shearFactorY);

        // Output the sheared matrix
        Console.WriteLine("Sheared Matrix along X:");
        for (int i = 0; i < shearedMatrixX.GetLength(0); i++)
        {
            for (int j = 0; j < shearedMatrixX.GetLength(1); j++)
            {
                Console.Write($"{shearedMatrixX[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Sheared Matrix along Y:");
        for (int i = 0; i < shearedMatrixY.GetLength(0); i++)
        {
            for (int j = 0; j < shearedMatrixY.GetLength(1); j++)
            {
                Console.Write($"{shearedMatrixY[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
*/