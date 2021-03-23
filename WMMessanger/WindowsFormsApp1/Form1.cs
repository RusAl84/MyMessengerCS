using ConsoleMessenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleMessenger;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    private static int MessageID;
    private static string UserName;
    private static MessangerClientAPI API = new MessangerClientAPI();
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string UserName = UserNameTB.Text;
      string Message = MessageTB.Text;
      if ((UserName.Length > 1) && (UserName.Length > 1))
      {
        ConsoleMessenger.Message msg = new ConsoleMessenger.Message(UserName, Message, DateTime.Now);
        API.SendMessageRestSharp(msg);
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {

      var getMessage = new Func<Task>(async () =>
      {
        ConsoleMessenger.Message msg = await API.GetMessageHTTPAsync(MessageID);
        while (msg != null)
        {
          MessagesLB.Items.Add(msg);
          MessageID++;
          msg = await API.GetMessageHTTPAsync(MessageID);
        }
      });
      getMessage.Invoke();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      MessageID = 0;
    }

    private void MessagesLB_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
