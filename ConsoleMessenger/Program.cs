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
      Message msg = new Message("Rusal","Privet", DateTime.UtcNow);
      string output = JsonConvert.SerializeObject(msg);
      Message deserializedProduct = JsonConvert.DeserializeObject<Message>(output);

    }
  }
}
