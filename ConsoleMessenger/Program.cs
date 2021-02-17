using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ConsoleMessenger
{
  class Program
  {
    static void Main(string[] args)
    {
      // Тест JSon SerializeObject NewtonSoft
      Message msg = new Message("RusAl","Privet", DateTime.UtcNow);
      string output = JsonConvert.SerializeObject(msg);
      Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
      Console.WriteLine(deserializedMsg);



      // Create the file.
      //string path = @"d:\temp\ser.txt";
      //using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
      //{
      //  sw.WriteLine(output);
      //}

    }
  }
}
