using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMessenger
{
  [Serializable]
  class Message
  {
    string UserName;
    string MessageText;
    DateTime TimeStamp;

    public Message(string userName, string messageText, DateTime timeStamp)
    {
      UserName = userName;
      MessageText = messageText;
      TimeStamp = timeStamp;
    }
  }
}
