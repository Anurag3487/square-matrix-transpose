using System;

namespace MatrixTranspose
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixTranspose();
        }

        private static void MatrixTranspose()
        {
            Console.WriteLine("Please enter the number of rows and columns for the matrix:");

            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColumns = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the matrix:\n");

            //Initialize a 2 dimensional array
            int[,] matrix = new int[numberOfRows, numberOfColumns];

            for(int i=0;i<numberOfRows;i++)
            {
                for(int j=0;j<numberOfColumns;j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe matrix entered is as follows: \n");
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write(matrix[i, j]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe transpose of the matrix is as follows: \n");
            for(int i=0;i< numberOfRows; i++)
            {
                for(int j=0;j<numberOfColumns;j++)
                {
                    Console.Write(matrix[j,i] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
