using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using ConsoleApp.Services;

var menu = new MenuService();
menu.FilePath = @$"{AppDomain.CurrentDomain.BaseDirectory}\content.json";


Console.Clear();
while (true)
{
    Console.Clear();
    menu.WelcomeMenu();
}