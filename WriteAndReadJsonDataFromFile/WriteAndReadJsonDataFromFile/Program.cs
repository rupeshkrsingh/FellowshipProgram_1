using Newtonsoft.Json;
using System;
using System.IO;
/// <summary>
/// jfkjfkjf
/// </summary>
/// <summary>
/// jfkjfkjfsfhwjkfwekj
/// </summary>
namespace WriteAndReadJsonDataFromFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PageStatus status = new PageStatus()
            {
                PageName = "RunEventPage"
            };
        

            string JsonResult = JsonConvert.SerializeObject(status);
            string FilePath = "D:\\PageStatus\\EventStatus.txt";

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
                using (var tw = new StreamWriter(FilePath, true))
                {
                    tw.WriteLine(JsonResult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(FilePath))
            {
                using (var tw = new StreamWriter(FilePath, true))
                {
                    tw.WriteLine(JsonResult.ToString());
                    tw.Close();
                }
            }



            //var jsonText = File.ReadAllText(FilePath);
            //var EventStatus = JsonConvert.DeserializeObject<PageStatus>(jsonText);
            //if (EventStatus.PageName=="RunEventPage")
            //{
            //    Console.WriteLine("RunEvent Page Enable");
            //}
            //else
            //{
            //    Console.WriteLine("SuperTracePage Enable");
            //}
            //Console.ReadKey();
        }
    }
}
