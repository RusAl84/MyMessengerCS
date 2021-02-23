using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMessenger
{
  [Serializable]
  public class Message
  {
    public string UserName { get; set; }
    public string MessageText { get; set; }
    public DateTime TimeStamp { get; set; }

    public Message()
    {
      UserName = "System";
      MessageText = "Server is running";
      TimeStamp = DateTime.UtcNow;
    }

    public Message(string userName, string messageText, DateTime timeStamp)
    {
      UserName = userName;
      MessageText = messageText;
      TimeStamp = timeStamp;
    }

    public override string ToString()
    {
      string output = String.Format("{0} {1} {2}", UserName, MessageText, TimeStamp);
      return output;
    }
  }
}
