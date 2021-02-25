using ConsoleMessenger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace UWPMessanger
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
    private static int MessageID;
    private static string UserName;
    private static MessangerClientAPI API = new MessangerClientAPI();
    DispatcherTimer timer;

    public MainPage()
        {

            this.InitializeComponent();

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

    private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
  }
}
