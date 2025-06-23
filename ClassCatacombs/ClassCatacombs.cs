using static BasicConsoleIO.BasicConsoleIO;
namespace ClassCatacombs;

class ClassCatacombs
{
    static void Main(string[] args)
    {
        ShowMainMessage("The Point");
        Point first = new Point(2, 3);
        Point second = new Point(-4, 0);
        ShowMessage($"Значения {nameof(first)} X: {first.X}, Y: {first.Y}", ConsoleColor.Magenta);
        ShowMessage($"Значения {nameof(second)} X: {second.X}, Y: {second.Y}", ConsoleColor.DarkYellow);
        //Answer: X и Y задаются как автоматические свойства с приватными мутаторами, чтобы избежать их изменяемости
        Console.ReadKey();
        Console.Clear();
        ShowMainMessage("The Color");

        Color userColor = new Color(123, 224, 022);
        Color statColor = Color.WhiteColor;

        ShowMessage($"Значения пользовательского цвета Red: {userColor.Red} Green: {userColor.Green} Blue: {userColor.Blue}", ConsoleColor.Cyan);
        ShowMessage($"Значения статического цвета Red: {statColor.Red} Green: {statColor.Green} Blue: {statColor.Blue}", ConsoleColor.Green);
    }
}
