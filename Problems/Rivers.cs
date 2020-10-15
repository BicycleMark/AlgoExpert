using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Problems
{
    public class Rivers
    {
        bool[,] visited;
        int[,] boardToFill; 

        List<int> lstSolve;
     
        public int[] Solve(int [,] matrix)
        {
           lstSolve = new List<int>();
           visited = new bool[matrix.GetLength(0),matrix.GetLength(1)];
           boardToFill = new int[matrix.GetLength(0), matrix.GetLength(1)];
           for (int i = 0; i < visited.GetLength(0); i++) 
           {
                for (int j = 0; j < visited.GetLength(1); j++)
                {
                    visited[i, j] = false;
                    boardToFill[i,j] = matrix[i, j];
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
                            floodFill(i, j, 1,  fillItem++) ;
                        }                     
                    }               
                }
           }
           return lstSolve.OrderBy(x => x).ToArray();
        }

        bool inBounds(int i, int j)
        {
            return !(i < 0 || j < 0 || i >= boardToFill.GetLength(0) || j >= boardToFill.GetLength(1));
        }
        private void floodFill(int r, int c, int spotVal,  int swapVal)
        {
            
            if (!inBounds(r, c)
                || boardToFill[r, c] != spotVal
                || visited[r,c])
            {
                if (inBounds(r, c))
                    visited[r, c] = true;
                return;
            }
            //Set To Fill Value
            boardToFill[r,c] = swapVal;
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
            floodFill(r + 1, c, spotVal, swapVal);
            floodFill(r - 1, c, spotVal, swapVal);
            floodFill(r, c + 1, spotVal, swapVal);
            floodFill(r, c - 1, spotVal, swapVal);
        }
    }   
}
