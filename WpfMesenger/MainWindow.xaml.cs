using ConsoleMessenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfMesenger
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private static int MessageID;
    private static string UserName;
    private static MessangerClientAPI API = new MessangerClientAPI();
    DispatcherTimer timer;

    public MainWindow()
    {
      InitializeComponent();
      timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 1) }; // 1 секунда
      timer.Tick += Timer_Tick;
      timer.Start();
    }

    private void Timer_Tick(object sender, object e)
    {
      ConsoleMessenger.Message msg = API.GetMessage(MessageID);
      while (msg != null)
      {
        MessagesLB.Items.Add(msg);
        MessageID++;
        msg = API.GetMessage(MessageID);
      }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      string UserName = UserNameTB.Text;
      string Message = MessageTB.Text;
      if ((UserName.Length > 1) && (UserName.Length > 1))
      {
        ConsoleMessenger.Message msg = new ConsoleMessenger.Message(UserName, Message, DateTime.Now);
        API.SendMessage(msg);
      }
    }
  }
}
