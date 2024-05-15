using Helpers;
using System.Threading;
List<MenuItem> menuItems = [];
Menu menu = new(menuItems);

MenuItem menuItem = new(1.00, "Ham and Cheese", "app");


Console.WriteLine(menu);
menu.AddMenuItem(menuItem, DateTime.Now);
Console.WriteLine(menu.LastUpdated);
Thread.Sleep(2000);
Console.WriteLine(menu.LastUpdated);

