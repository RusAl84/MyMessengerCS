using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace ConsoleMessenger
{
  class Program
  {
    private static int MessageID;
    private static string UserName;
    private static MessangerClientAPI API = new MessangerClientAPI();

    private static void GetNewMessages()
    {
      Message msg = API.GetMessage(MessageID);
      while (msg != null)
      {
        Console.WriteLine(msg);
        MessageID++;
        msg = API.GetMessage(MessageID);
      }
    }
    static void Main(string[] args)
    {
      MessageID = 1;
      Console.WriteLine("Введите Ваше имя:");
      //UserName = "RusAl";
      UserName = Console.ReadLine();
      string MessageText = "";
      while (MessageText != "exit") {
        GetNewMessages();
        MessageText = Console.ReadLine();
        if (MessageText.Length > 1)
        {
          Message Sendmsg = new Message(UserName, MessageText, DateTime.Now);
          API.SendMessage(Sendmsg);
        }
      }
    }
  }
}
