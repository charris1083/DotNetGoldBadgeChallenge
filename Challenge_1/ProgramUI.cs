using System;

namespace Challenge_1
{
    class ProgramUI
    {

        MenuRepo _menuRepo = new MenuRepo();


        public void RunMenu()
        {

            Console.WriteLine("Welcome to Komodo Cafe");
            Console.ReadLine();
            bool menuRun = true;

            while (menuRun)
            {
                Console.WriteLine("Choose food item." +
                    "\n1. Add Menu item" +
                    "\n2. Delete Menu item" +
                    "\n3. See all" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateMenu();
                        Console.ReadKey();
                        break;
                    case 2:
                        DeleteMenuItem();
                        Console.ReadKey();
                        break;
                    case 3:
                        SeeAll();
                        Console.ReadKey();
                        break;
                    case 4:
                        menuRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        private void SeeAll()
        {
            var allItemsInMenu = _menuRepo.SeeAllMenuItems();

            Console.WriteLine("Num, Name, Description, Ingredients, Price");
            foreach (var menu in allItemsInMenu)
            {
                Console.WriteLine($"{menu.FoodNumber}, {menu.FoodName}, {menu.Description}, {menu.Ingredients}, {menu.Price} .");
            }
        }

        private void DeleteMenuItem()
        {
            Console.WriteLine("Which Menu item would you like to delete?");
            foreach(MenuItem menu in _menuRepo.SeeAllMenuItems() )
            {
                Console.WriteLine($"{menu.FoodNumber} {menu.FoodName} {menu.Description} {menu.Ingredients} {menu.Price}");
            }
            var removeNumber = int.Parse(Console.ReadLine());
            foreach(MenuItem menu in _menuRepo.SeeAllMenuItems())
            {
                if (menu.FoodNumber == removeNumber)
                {
                    _menuRepo.RemoveMenuItem(menu);
                    break;
                }
            }
        }

        private void CreateMenu()
        {
            Console.Clear();
            MenuItem newItem = new MenuItem();
            Console.WriteLine("Enter Number:");
            newItem.FoodNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Meal Name: ");
            newItem.FoodName = Console.ReadLine();

            Console.WriteLine("Enter Descrition: ");
            newItem.Description = Console.ReadLine();

            Console.WriteLine("Enter Ingredients: ");
            newItem.Ingredients = Console.ReadLine();

            Console.WriteLine("Enter Price: ");
            newItem.Price = decimal.Parse(Console.ReadLine());

            _menuRepo.AddMenuItem(newItem);
        }
    }
}

