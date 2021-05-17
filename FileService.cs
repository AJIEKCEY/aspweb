using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace aspweb
{
    public class FileService
    {
        
        public int WritePostToFile(string path, Post data)
        {
            try
            {
                string jsonstring = JsonSerializer.Serialize(data);
                
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(jsonstring);
                }

                Console.WriteLine("Запись выполнена");
                
                return -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }
        }
    }
}