using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AkhmetovRR.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(filePath);
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string res = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != matrix.GetLength(1) - 1)
                    {
                        res += matrix[i, j] + ";";
                    }
                    else
                    {
                        res += matrix[i, j];
                    }
                }
                if (i != matrix.GetLength(0) - 1)
                {
                    File.AppendAllText(filePath, res + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, res);
                }
                res = "";
            }
            return filePath;
        }
    }
}