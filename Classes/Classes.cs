using static BasicConsoleIO.BasicConsoleIO;
namespace Classes;

class Classes
{
    static void Main(string[] args)
    {
        Arrow strela = new Arrow();
        Console.Clear();
        ShowMainMessage("Vin Fletchers Arrows");
        ShowMessage($"Стоимость вашей стрелы {nameof(strela)}: {strela.GetCost()}", ConsoleColor.DarkYellow);
    }


}
