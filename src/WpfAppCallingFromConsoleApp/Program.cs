// See https://aka.ms/new-console-template for more information
using WpfAppCallingFromConsoleApp.Gui;

// 最初にUnknownに設定しないといけない
Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
Thread.CurrentThread.SetApartmentState(ApartmentState.STA);

var app = new App();

app.Run();
