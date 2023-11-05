using System;

class MatrixMath{

    public static double[,] MultiplyScalar(double[,] matrix, double scalar){
        if(matrix.GetLength(1) == 2 || matrix.GetLength(1) == 3){
            for(int i = 0; i < matrix.GetLength(0); i++){
                for(int j = 0; j < maxtrix.GetLength(1); j++){
                    matrix[i,j] = scalar * matrix[i,j];
                }
            }
            return matrix;
        }

        return new double[]{{-1}};
    }
}