using ConsoleApp.Services;

var menu = new MenuService();
menu.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";


Console.Clear();
while (true)
{
    Console.Clear();
    menu.WelcomeMenu();
}