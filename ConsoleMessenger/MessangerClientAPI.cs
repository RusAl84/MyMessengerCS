using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMessenger
{
  class MessangerClientAPI
  {
    public void TestNewtonsoftJson()
    {
      // Тест JSon SerializeObject NewtonSoft
      Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
      string output = JsonConvert.SerializeObject(msg);
      Console.WriteLine(output);
      Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
      Console.WriteLine(deserializedMsg);
      //string path = @"d:\temp\ser.txt";
      //using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
      //{
      //  sw.WriteLine(output);
      //}
    }

    public Message GetMessage(int MessageId)
    {
      WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger/" + MessageId.ToString());
      request.Method = "Get";
      WebResponse response = request.GetResponse();
      string status = ((HttpWebResponse)response).StatusDescription;
      //Console.WriteLine(status);
      Stream dataStream = response.GetResponseStream();
      StreamReader reader = new StreamReader(dataStream);
      string responseFromServer = reader.ReadToEnd();
      //Console.WriteLine(responseFromServer);
      reader.Close();
      dataStream.Close();
      response.Close();
      if ((status.ToLower() == "ok") && (responseFromServer != "Not found"))
      {
        Message deserializedMsg = JsonConvert.DeserializeObject<Message>(responseFromServer);
        //Console.WriteLine(deserializedMsg);
        return deserializedMsg;
      }
      return null;
    }

    public bool SendMessage(Message msg)
    {
      WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger");
      request.Method = "POST";
      //Message msg = new Message("RusAl", "Privet1100", DateTime.Now);
      string postData = JsonConvert.SerializeObject(msg);
      byte[] byteArray = Encoding.UTF8.GetBytes(postData);
      request.ContentType = "application/json";
      request.ContentLength = byteArray.Length;
      Stream dataStream = request.GetRequestStream();
      dataStream.Write(byteArray, 0, byteArray.Length);
      dataStream.Close();
      WebResponse response = request.GetResponse();
      //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
      dataStream = response.GetResponseStream();
      StreamReader reader = new StreamReader(dataStream);
      string responseFromServer = reader.ReadToEnd();
      //Console.WriteLine(responseFromServer);
      reader.Close();
      dataStream.Close();
      response.Close();
      return true;
    }
  }
}
