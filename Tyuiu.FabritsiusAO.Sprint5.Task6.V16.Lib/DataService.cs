using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FabritsiusAO.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public int LoadFromDataFile(string path)
        {
            int C = 0;
            using (StreamReader R = new(path))
            {
                string L;
                while ((L = R.ReadLine()) != null)
                {
                    for (int i = 0; i < L.Length; i++)
                    {
                        if (L[i] >= 'A' && L[i] <= 'z')
                        {
                            if ((L[i + 1] == ' ') || (L[i + 1] == '.') || (L[i + 1] == ','))
                            {
                                C++;
                            }
                        }
                    }
                }
            return C;
            }
        }
    }
}
