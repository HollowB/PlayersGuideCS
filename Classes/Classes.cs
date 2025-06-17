using static BasicConsoleIO.BasicConsoleIO;
using static Tuples.Menu;
namespace Classes;

class Classes
{
    static void Main(string[] args)
    {
        string[] arrows = new string[] { "Элитная", "Меткая", "Для новичков", "Кастомная" };
        //Arrow strela = new Arrow();
        Console.Clear();
        ShowMainMessage("Vin Fletchers Arrows");
        //InitiateMenu(arrows, "Тип стрелы");

        Arrow strela;
        string type = InitiateMenu(arrows, "Тип стрелы");
        switch (type)
        {
            case "Элитная":
                strela = Arrow.CreateEliteArrow();
                break;
            case "Меткая":
                strela = Arrow.CreateMarksmanArrow();
                break;
            case "Для новичков":
                strela = Arrow.CreateBeginnerArrow();
                break;
            default:
                strela = new Arrow(0);
                break;
        }
        ShowMessage($"\nСтоимость вашей стрелы {nameof(strela)}: {strela.GetCost()}", ConsoleColor.DarkYellow);
    }


}
