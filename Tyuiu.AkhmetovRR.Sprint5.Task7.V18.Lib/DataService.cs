using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AkhmetovRR.Sprint5.Task7.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V18.txt" });


            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSave);
            }
            string fileContent = File.ReadAllText(path);

            string modifiedContent = fileContent.Replace("н", "нн");

            File.WriteAllText(pathSave, modifiedContent);
            return pathSave;
        }
    }
}
