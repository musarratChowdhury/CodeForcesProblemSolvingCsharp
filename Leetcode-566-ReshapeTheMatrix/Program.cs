

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
            //var line1 = ReadLine()?.Split(" ");
            //int n = Convert.ToInt32(line1?[0]);
            //int m = Convert.ToInt32(line1?[1]);
            //var line2 = ReadLine()?.Split(" ");
            //necessary variables


            //solution
            var testArr = new int[1][];
            testArr[0] = new int[] { 1, 2 };
            //testArr[1] = new int[] { 3, 4 };
            var test = MatrixReshape(testArr, 1, 1);
            foreach(var r in test)
            {
                WriteLine("row");
                foreach (var c in r)
                {
                    WriteLine(c);
                }
            }
            //MatrixReshape(testArr,4,5);





        }

        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            var result = new int[r][];
            var arr = new Queue<int>();
            int totalElementOfMat = 0;
            var initialarrRow = mat.Length;
            var initialarrCol = mat[0].Length;

            var outputarrLength = r * c;
            if (outputarrLength > initialarrRow * initialarrCol) return mat;
            
            //return result;
            for (int rIndex = 0; rIndex<mat.Length;rIndex++)
            {
                //WriteLine($"row : {rIndex} : ");
                for(int colIndex = 0; colIndex < mat[rIndex].Length;colIndex++)
                {
                    //WriteLine($"col : {colIndex} : value : {mat[rIndex][colIndex]}");
                    arr.Enqueue(mat[rIndex][colIndex]);
                    totalElementOfMat++;    
                }
            }
         

            for(int i = 0; i < r; i++)
            {
                var row = new List<int>();
                for(int j= 0; j<totalElementOfMat/r; j++)
                {
                    row.Add(arr.Dequeue());
                }
                result[i] = row.ToArray();
            }
            return result;
        }

    }
}