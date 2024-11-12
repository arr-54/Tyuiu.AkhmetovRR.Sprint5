using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.FabritsiusAO.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            double res = 2;
            using (StreamReader R = new(path))
            {
                string L = R.ReadLine();
                L = L.Replace('.', ',');
                L = L.Replace(' ', '\n');
                while ((L = R.ReadLine()) != null)
                {
                    if (res < Convert.ToDouble(L) && Convert.ToDouble(L) % 1 == 0);
                    {
                        res = Convert.ToDouble(L);
                    }
                }
            }
            return res;
        }
    }
}
