using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FabritsiusAO.Sprint5.Task2.V10.Lib
{
    public class DataService : ISprint5Task2V10
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            DataService ds = new();
            string path = Path.GetTempFileName();
            int row = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / row;
            int[,] array = ds.CalculateArray(matrix);

            string str = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j != col - 1)
                    {
                        str = str + matrix[i, j]+";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != row - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
        public int[,] CalculateArray(int[,] matrix)
        {
            int row = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / row;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
