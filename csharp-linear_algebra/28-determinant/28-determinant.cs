using System;

class MatrixMath{

    public static double Determinant(double[,] matrix){

        if(matrix.GetLength(0) == 2 || matrix.GetLength(1) == 3){

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if(rows == 2){
                return ((matrix[0,0] * matrix[1,1]) - matrix([0,1] * matrix[1,0]));
            }

            if(rows == 3){
                int x = matrix[0,0] * ((matrix[1,1] * matrix[2,2]) - (matrix[2,1] * matrix[1,2]));
                int y = matrix[0,1] * ((matrix[1,0] * matrix[2,2]) - (matrix[2,0] * matrix[1,2]));
                int z = matrix[0,2] * ((matrix[1,0] * matrix[2,1]) - (matrix[2,0] * matrix[1,1]));

                return ( x - y - z);
            }
        }

        return -1;
    }
}