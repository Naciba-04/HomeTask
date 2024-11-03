using FileStream.Model;
using Newtonsoft.Json;

namespace FileStream;

internal class Program
{
    static void Main(string[] args)
    {
        StudentMethods mtds = new(@"C:\Users\resul\Desktop\hometask\FileStream\FileStream\Files\names.json");
        string studentsStr = mtds.ReadAsync().Result;
        var list = JsonConvert.DeserializeObject<List<Student>>(studentsStr);
        Student std = new Student
        {
            Name = "Taravat"
        };
        list.Add(std);
        string result=JsonConvert.SerializeObject(list);
        mtds.ReplaceAsync(result).Wait();

    }
}


        //Console.WriteLine(result);
        //List<Student> list = [std];
        //string result = JsonConvert.SerializeObject(list);