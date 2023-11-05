using System;



class Program{

    public static void Main(){

        double[,] startedPoint = { {1, 2}, { 3, 4}};
        double[,] result = MatrixMath.Rotate2D(startedPoint, -1.57);
        
        for(int i = 0; i < 2 ; i++){
            for(int j = 0; j < 2; j++){
                Console.WriteLine(result[i,j]);
            }
        }

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

        if(rows == cols){
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

          return new double[,]{{-1}};
       
    }

  
}