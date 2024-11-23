using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AkhmetovRR.Sprint5.Task7.V18.Lib
{
    public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            string savefile = Path.GetTempFileName();
            string strline = "";
            using (StreamReader R = new(path))
            {
                string L;
                while ((L = R.ReadLine()) != null)
                {
                    for (int i = 0; i < L.Length; i++)
                    {
                        if (L[i] == 'н')
                        {
                            strline = strline + "нн";
                        }
                        else
                        {
                            strline = strline + Convert.ToString(L[i]);
                        }
                    }
                    File.AppendAllText(savefile, strline + Environment.NewLine);
                    strline = "";
                }
            }
            return savefile;
        }
    }
}
