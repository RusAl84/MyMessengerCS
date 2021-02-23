using System;
using Terminal.Gui;

namespace ConsoleMessengerWithGUI
{
  class Program
  {
    private static MenuBar menu;
    private static Window winMain;
    private static Window winMessages;
    private static Label labelUser;
    private static TextField fieldUsername;
    private static Label labelMessage;
    private static TextField fieldMessage;
    private static Button btnSend;

    static void Main(string[] args)
    {
      Application.Init();
      // Верхнеуровневый компонент
      var top = Application.Top;

      // Компонент меню
      menu = new MenuBar(new MenuBarItem[]
      {
                new MenuBarItem("_App", new MenuItem[]
                {
                    new MenuItem("_Quit", "Close the app", Application.RequestStop),
                }),
      });
      top.Add(menu);

      // Компонент главной формы
      winMain = new Window()
      {
        Title = "DotChat",
        // Позиция начала окна
        X = 0,
        Y = 1, //< Место под меню
               // Авто растягивание по размерам терминала
        Width = Dim.Fill(),
        Height = Dim.Fill()
      };
      top.Add(winMain);

      // Компонент сообщений
      winMessages = new Window()
      {
        X = 0,
        Y = 0,
        Width = winMain.Width,
        Height = winMain.Height - 2,
      };
      winMain.Add(winMessages);

      Application.Run();
    }
  }
}
