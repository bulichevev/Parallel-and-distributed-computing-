using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MConsole mConsole = new MConsole();

            int i = 0;
            mConsole.GetInteger("размер матрицы:", ref i);
            if (i > 0)
            {
                Math math = new Math(i);
                int[,] matrixResult = math.MatrixMult(math.matrix1, math.matrix2);

                math.PrintMatrix(math.matrix1, "\nПервая матрица");
                math.PrintMatrix(math.matrix2, "\nВторая матрица");
                math.PrintMatrix(matrixResult, "\nпроизведение матриц");

                Console.WriteLine($"\nВремя выполнения: {math.timeElapsed}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введите значение больше 0");
            }


            Console.ReadKey();
        }
    }

}
