
using System;
using static System.Console;
using System.Text;
using System.Linq;
using System.Threading;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] F = new int[101];
            //solution

            //WriteLine(Fib(40, F));
            //WriteLine(pascalTriangle(5, 4));
            //PrintPascalTriangle(5);
            var printPascal = GetPascalTriangle(40);
            foreach(var row in printPascal)
            {
                Write(row.Count + " "+":");
                foreach(var col in row)
                {
                    Write(col+" ");
                }
                WriteLine();
            }



        }
        static int Fib(int n, int[]F)
        {

            if(n<=2)
            {
                return 1;
            }
            if (F[n]!=0)
            {
                return F[n];
            }
            F[n] = Fib(n - 1,F) + Fib(n - 2,F);
            return F[n];
        }
        static void PrintPascalTriangle(int rows)
        {
            var storage = new int[rows + 1][];

            for (int r = 0;r<rows;r++)
            {
                Write($"Row {r} : ");
                for(int c = 0;c<=r;c++)
                {
                    //Write($" {pascalTriangleCalc(r,c, storage)} ");
                }
                WriteLine();
            }
        }
        static int[][] GetPascalTriangleJaggedArr(int rows)
        {
            var storage = new int[rows + 1][];

            var result = new int[rows+1][];
            for (int r = 0; r < rows; r++)
            {
              
                var colList = new List<int>();
                for (int c = 0; c <= r; c++)
                {
               
                    //colList.Add(pascalTriangleCalc(r, c, storage));
                }
              
                result[r] = colList.ToArray();
            }
            return result;
        }
        static IList<IList<int>> GetPascalTriangle(int numRows)
        {
            
            var storage = new int[numRows + 1,numRows+1];

            List<int>[] result = new List<int>[numRows];
            for (int r = 0; r < numRows; r++)
            {

                //var colList = new List<int>();
                result[r] = new List<int>();
                for (int c = 0; c <= r; c++)
                {

                    result[r].Add(pascalTriangleCalc(r, c,storage));
                }

                //result.(colList);
            }
             return result;
        }
        static int pascalTriangleCalc(int row,int col, int[,] storage)
        {
            if (row >= 0 && (col == 0 || col == row)) return 1;
            if (storage[row,col]!=0) return storage[row,col];
            else
            {
                storage[row,col] = pascalTriangleCalc(row - 1, col,storage) + pascalTriangleCalc(row - 1, col - 1,storage);
                return storage[row,col];
            }
        }
    }
}