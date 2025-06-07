using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BasicConsoleIO.BasicConsoleIO;
namespace DecisionMaking
{
    class SwitchDecisionMaking
    {
        public static void BuyingInventory()
        {
            bool decision, end = false;
            ShowMainMessage("Byuing inventory");
            string itemName;
            int itemCost;
            
            Dictionary<int, Dictionary<string, int>> menu = BuildMenu();
            Dictionary<string, int> shoppingCart = new Dictionary<string, int>();

            while (!end)
            {
                decision = false;
                ShowMagasineMenu(menu);
                itemCost = GetItemCost(menu, out itemName);
                ShowMessage($"\nOoo, {itemName}! А у тебя губа не дура!", ConsoleColor.DarkYellow);
                ShowMessage($"У меня самая лучшая цена на {itemName}, всего {itemCost} дублонов!", ConsoleColor.DarkYellow);
                GetUserInput("\nБудешь брать?", out decision);
                if (decision)
                {
                    Console.WriteLine("Славное решение, друг мой!");
                    shoppingCart.Add(itemName, itemCost);
                }
                GetUserInput("\nМожет ещё что-то интересует?", out end);
                end = !end;
            }
            ShowMessage("В добрый путь!", ConsoleColor.Blue);
        }


        private static Dictionary<int, Dictionary<string, int>> BuildMenu()
        {
            bool end = false;
            Dictionary<int, Dictionary<string, int>> shopMenu = new Dictionary<int, Dictionary<string, int>>();

            for (int i = 1; !end; i++)
            {
                Console.Clear();
                ShowMainMessage("Byuing inventory");
                shopMenu.Add(i, GetMenuItem());
                GetUserInput("Хотите завершить ввод?\n",out end);
            }
            return shopMenu;
        }

        private static Dictionary<string, int> GetMenuItem()
        {
            string itemName;
            int itemCost;
            Dictionary<string, int> item = new Dictionary<string, int>();
            GetUserInput("Пожалуйста, введите наименование товара: ", out itemName);
            GetUserInput($"Введите стоимость для {itemName}: ", out itemCost);
            item.Add(itemName, itemCost);
            return item;
        }
        private static void ShowMagasineMenu(Dictionary<int, Dictionary<string, int>> menu)
        {
            Console.Clear();
            ShowMainMessage("Byuing inventory");
            ShowMessage("\nВот товары, что у меня есть!\n", ConsoleColor.Green);

            string itemName = "";
            foreach (KeyValuePair<int, Dictionary<string, int>> kwp in menu)
            {
                foreach(KeyValuePair<string, int> keys in kwp.Value)
                {
                    itemName = keys.Key;
                }
                ShowMessage($"{kwp.Key} - {itemName}", ConsoleColor.Magenta);
            }
        }

        private static int GetItemCost(Dictionary<int, Dictionary<string, int>> value, out string itemName)
        {
            int cost = 0;
            int itemNumber;
            itemName = "";
            GetUserInput("\nСкажи, дорогой друг, под каким номером интересующий тебя товар?", out itemNumber);

            Dictionary<string, int> item = value[itemNumber];
            foreach (KeyValuePair<string, int> kvp in item)
            {
                cost = kvp.Value;
                itemName = kvp.Key;
            }
            return cost;
        }
    }
}










