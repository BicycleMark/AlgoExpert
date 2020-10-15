using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Problems
{
    public class Rivers
    {
        bool[,] visited;
        //int[,] boardToFill; 

        List<int> lstSolve;
     
        public int[] Solve(int [,] matrix)
        {
           lstSolve = new List<int>();
           visited = new bool[matrix.GetLength(0),matrix.GetLength(1)];
         //  boardToFill = new int[matrix.GetLength(0), matrix.GetLength(1)];
           for (int i = 0; i < visited.GetLength(0); i++) 
           {
                for (int j = 0; j < visited.GetLength(1); j++)
                {
                    visited[i, j] = false;
         //           boardToFill[i,j] = matrix[i, j];
                }
           }

           int fillItem = 1;
           for (int i = 0; i < visited.GetLength(0); i++)
           {
                for (int j = 0; j < visited.GetLength(1); j++)
                {
                    if (!visited[i,j])
                    {
                        if (matrix[i,j] == 0)
                        {
                            visited[i, j] = true;
                        }else
                        {   
                            floodFill(ref matrix, i, j, 1,  fillItem++) ;
                        }                     
                    }               
                }
           }
           return lstSolve.OrderBy(x => x).ToArray();
        }

       
        private void floodFill(ref int [,]  mat, int r, int c, int spotVal,  int swapVal)
        {

            bool inbounds = r >= 0 && c >= 0 && r < mat.GetLength(0) && c < mat.GetLength(1);
            if ( !inbounds
                || mat[r, c] != spotVal
                || visited[r,c])
            {
                if (inbounds)
                    visited[r, c] = true;
                return;
            }
            //Set To Fill Value
            mat[r,c] = swapVal;
            visited[r, c] = true;
            if (lstSolve.Count < swapVal)
            {
                lstSolve.Add(1);

            }else
            {
                var cnn = lstSolve.ToArray();
                cnn[swapVal - 1]++;
                lstSolve = cnn.ToList();
            }
            floodFill(ref mat, r + 1, c, spotVal, swapVal);
            floodFill(ref mat, r - 1, c, spotVal, swapVal);
            floodFill(ref mat, r, c + 1, spotVal, swapVal);
            floodFill(ref mat, r, c - 1, spotVal, swapVal);
        }
    }   
}
