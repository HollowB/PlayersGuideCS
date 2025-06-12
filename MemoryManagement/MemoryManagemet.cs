using static BasicConsoleIO.BasicConsoleIO;
using static Looping.Looping;
namespace MemoryManagement;

class MemoryManagemet
{
    static void Main(string[] args)
    {
        //GetUserInput("Первый игрок, как далеко от города вы хотите расположить Мантикору? ", out place);
        Game();
    }

    private static void Game()
    {
        int place, cityHealth = 15, manticoraHealth = 10;

        ShowMainMessage("HuntingTheManticore");

        GetPilotNumber(out place);

        Hunting(place, cityHealth, manticoraHealth);

    }

    private static void Hunting(int place, int cityHealth, int manticoraHealth)
    {
        bool result = false;
        int dmg, shotPlace, round = 0;
        Console.Clear();
        ShowMainMessage("HuntingTheManticore");
        for (; cityHealth > 0; cityHealth--)
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            ShowMessage($"СТАТУС: Раунд {++round}, Город: {cityHealth}/15, Мантикора: {manticoraHealth}/10", ConsoleColor.DarkGreen);
            Console.ReadKey();

            GetCannonDamage(round, out dmg);
            GetUserInput("Введите расстояние выстрела пушки: ", out shotPlace);
            ShotResult(shotPlace, place, out result);
            manticoraHealth = (result == true) ? manticoraHealth - dmg : manticoraHealth;
            if (manticoraHealth < 1)
            {
                break;
            }
        }

        if (cityHealth < 1)
        {
            ShowMessage("Город был уничтожен! Победа Unicoded One", ConsoleColor.Red);
        }
        else if(manticoraHealth < 1)
        {
            ShowMessage("Город уцелел! Мантикора разрушена! Победа горожан!", ConsoleColor.Green);
        }
    }

    private static void ShotResult(int shotPlace, int place, out bool result)
    {
        result = false;
        if (shotPlace == place)
        {
            result = true;
            ShowMessage("Это было ПРЯМОЕ попадание!", ConsoleColor.Green);
        }
        else if (shotPlace < place)
        {
            ShowMessage("Недолёт!", ConsoleColor.Red);
        }
        else
        {
            ShowMessage("Перелёт!", ConsoleColor.Red);
        }
    }

    private static void GetCannonDamage(int round, out int dmg)
    {
        if (round % 3 == 0 && round % 5 == 0)
        {
            dmg = 10;
            ShowMessage($"Пушка готова нанести {dmg} урона в этом раунде", ConsoleColor.Red);
        }
        else if (round % 3 == 0)
        {
            dmg = 3;
            ShowMessage($"Пушка готова нанести {dmg} урона в этом раунде", ConsoleColor.Yellow);
        }
        else if (round % 5 == 0)
        {
            dmg = 3;
            ShowMessage($"Пушка готова нанести {dmg} урона в этом раунде", ConsoleColor.Yellow);
        }
        else
        {
            dmg = 1;
            ShowMessage($"Пушка готова нанести {dmg} урона в этом раунде", ConsoleColor.White);
        }
    }
}

    
