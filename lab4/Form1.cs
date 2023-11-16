using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        // Creeaza o matrice cu valori arbitrare

        // Calculeaza minimul, maximul, totalul si media pentru 
        // toata matricea, fiecare rand si fiecare coloana
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] matrix = new int[5, 5]
            {
                { 4, 5, 7, 0, 9},
                { 1, 3, 5, 1, 2},
                { 4, 8, 9, 16, 15},
                { 23, 33, 4, 5, 9},
                { 6, 9, 42, 1, 0}
            };
            int matrixMin; int matrixMax; 
            int matrixTotal = 0; 
            double matrixMean;

            matrixMin = matrix[0, 0];
            matrixMax = matrix[0, 0];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrixMin > matrix[row, column])
                    {
                        matrixMin = matrix[row, column];
                    }

                    if (matrixMax < matrix[row, column])
                    {
                        matrixMax = matrix[row, column];
                    }

                    matrixTotal += matrix[row, column];
                }
            }

            matrixMean = matrixTotal / matrix.Length;
            Console.WriteLine("Matrix min = " + matrixMin);
            Console.WriteLine("Matrix max = " + matrixMax);
            Console.WriteLine("Matrix total = " + matrixTotal);
            Console.WriteLine("Matrix mean = " + matrixMean);

            // -------------------------------------------------------

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int rowMin = matrix[row, 0]; 
                int rowMax = matrix[row, 0]; 
                int rowTotal = 0; 
                double rowMean;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (rowMin > matrix[row, col])
                    {
                        rowMin = matrix[row, col];
                    }
                    if (rowMax < matrix[row, col])
                    {
                        rowMax = matrix[row, col];
                    }

                    rowTotal += matrix[row, col];
                }

                rowMean = rowTotal / matrix.GetLength(1);

                Console.WriteLine("Row " + row + " min = " + rowMin);
                Console.WriteLine("Row " + row + " max = " + rowMax);
                Console.WriteLine("Row " + row + " total = " + rowTotal);
                Console.WriteLine("Row " + row + " mean = " + rowMean);
            }

            // -------------------------------------------------------

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int colMin = matrix[0, col];
                int colMax = matrix[0, col];
                int colTotal = 0;
                double colMean;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (colMin > matrix[row, col])
                    {
                        colMin = matrix[row, col];
                    }
                    if (colMax < matrix[row, col])
                    {
                        colMax = matrix[row, col];
                    }

                    colTotal += matrix[row, col];
                }

                colMean = (double)colTotal / (double)matrix.GetLength(0);

                Console.WriteLine("Col " + col + " min = " + colMin);
                Console.WriteLine("Col " + col + " max = " + colMax);
                Console.WriteLine("Col " + col + " total = " + colTotal);
                Console.WriteLine("Col " + col + " mean = " + colMean);

            }
        }
    }
}
