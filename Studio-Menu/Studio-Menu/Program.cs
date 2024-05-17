using Helpers;
using System.Threading;
List<MenuItem> menuItems = [];
Menu menu = new();

MenuItem Sandwich = new(1.00, "Ham and Cheese", "app");
menu.AddMenuItem(Sandwich);

MenuItem Burger = new(3.00, "Cheese Burger", "main");
menu.AddMenuItem(Burger);

MenuItem Cake = new(7.00, "Five Layer Cake", "dessert");
menu.AddMenuItem(Cake);


MenuItem Cheese = new(11.00, "Cheese bread", "main");
menu.AddMenuItem(Cheese);

Console.WriteLine(menu);

menu.RemoveMenuItem("Cheese bread");

Console.WriteLine(menu);
Console.WriteLine(menu.LastUpdated);


