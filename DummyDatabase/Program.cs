using System;
using System.Collections.Generic;

namespace DummyDatabase
{
    class Menu
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Menu> SubMenu { get; set; }
    }

    internal class Program
    {
        private static Menu menu = new()
        {
            Id = 1,
            Text = "Меню программы",
            SubMenu = new List<Menu>()
            {
                new Menu
                {
                    Text = "Просмотр",
                    SubMenu = new List<Menu>
                    {
                        new Menu
                            {
                            Id = 2,
                                Text = "Книги"
                            },
                        new Menu
                            {
                                Id = 2,
                                Text = "Читатели"
                            }
                },
                 new Menu
                    {
                        Text = "Редактировать",
                        SubMenu = new List<Menu>
                        {
                            { 4, new Menu
                                {
                                    Text = "Книги"
                                }
                            },
                            { 5, new Menu
                                {
                                    Text = "Читатели"
                                }
                            }
                        }
                }
            }
        };

        static void PrintMenu(Menu menu, int selectedId, int tabCount)
        {
            if (selectedId == 0)
            Console.WriteLine($"{new String('\t', tabCount)} {menu.Text}");
            if (menu.SubMenu != null)
            {
                foreach (var pair in menu.SubMenu)
                {
                    var subMenu = pair.Value;
                    var id = pair.Key;

                    PrintMenu(subMenu, selectedId, tabCount+1);
                }
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
