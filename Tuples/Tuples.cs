using static BasicConsoleIO.BasicConsoleIO;
namespace Tuples;

class Tuples
{
    static void Main(string[] args)
    {
        SimulasSoup();
        //TestTuples();
    }

    static private void TestTuples()
    {
        ShowMainMessage("Hi! I`m testing Tuples!");
        (string, int, int[]) tupleOne = ("test", 1489, new int[] {1,2,3});
        var tupleTwo = tupleOne;

        ShowTupleMembers(tupleOne, ConsoleColor.DarkGreen, nameof(tupleOne));
        ShowTupleMembers(tupleTwo, ConsoleColor.DarkYellow, nameof(tupleTwo));

        Console.WriteLine();
        tupleTwo.Item1 = "TestChangingValue";
        tupleTwo.Item2 = 500;
        tupleTwo.Item3[2] = 322;
        ShowTupleMembers(tupleTwo, ConsoleColor.DarkYellow, nameof(tupleTwo));
        ShowTupleMembers(tupleOne, ConsoleColor.DarkGreen, nameof(tupleOne));


    }

    private static void ShowTupleMembers((string, int, int[]) tuple, ConsoleColor color, string tupleName)
    {
        ShowMessage($"Значение Item1 из {tupleName}: {tuple.Item1}", color);
        ShowMessage($"Значение Item2 из {tupleName}: {tuple.Item2}", color);
        ShowMessage($"Значение Item3 из {tupleName}: {{ {tuple.Item3[0]}, {tuple.Item3[1]}, {tuple.Item3[2]} }}", color);
    }

    public static void SimulasSoup()
    {
        (string seasoning, string type, string ingridient) soup = (
            Menu.InitiateMenu(Enum.GetNames(typeof(Специи)), nameof(Специи)),
            Menu.InitiateMenu(Enum.GetNames(typeof(Тип)), nameof(Тип)), 
            Menu.InitiateMenu(Enum.GetNames(typeof(Ингредиент)), nameof(Ингредиент)));
        //string seasoning = Menu.InitiateMenu(Enum.GetNames(typeof(Специи)), nameof(Специи));
        //string type = Menu.InitiateMenu(Enum.GetNames(typeof(Тип)), nameof(Тип));
        //string ingridient = Menu.InitiateMenu(Enum.GetNames(typeof(Ингредиент)), nameof(Ингредиент));

        Console.Clear();
        Console.WriteLine();

        ShowMessage($"{soup.seasoning} {soup.type} из {soup.ingridient} ", ConsoleColor.Blue);
    }
}
