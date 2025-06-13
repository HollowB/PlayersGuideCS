using static BasicConsoleIO.BasicConsoleIO;
namespace Enumerations;

class Enumerations
{
    static void Main(string[] args)
    {
        SimulasTest();
    }

    static void SimulasTest()
    {
        ShowMainMessage("Simula`s Test");
        
        ChestState state = ChestState.Заблокирован;
        while (true)
        {
            state = ManipulateChest(state);
        }
    }

    private static ChestState ManipulateChest(ChestState state)
    {
        ChestCommand command;
        command = GetCommand(state);
        state = ManipulateConfirm(state, command);

        return state;

    }

    private static ChestState ManipulateConfirm(ChestState state, ChestCommand command)
    {
        switch (state)
        {
            case ChestState.Открыт:
                if (command == ChestCommand.Закрыть)
                {
                    state = ChestState.Разблокирован;
                }
                break;
            case ChestState.Разблокирован:
                if (command == ChestCommand.Открыть)
                {
                    state = ChestState.Открыт;
                }
                else if (command == ChestCommand.Заблокировать)
                {
                    state = ChestState.Заблокирован;
                }
                break;
            case ChestState.Заблокирован:
                if (command == ChestCommand.Разблокировать)
                {
                    state = ChestState.Разблокирован;
                }
                break;
            default:
                break;
        }

        return state;
    }

    private static ChestCommand GetCommand(ChestState state)
    {
        bool correct = false;
        ChestCommand command = ChestCommand.Заблокировать;
        while (!correct)
        {
            
            string com;
            GetUserInput($"Сундук {state.ToString()}. Что вы хотите сделать? ", out com);
            if (com.ToLower() == ChestCommand.Заблокировать.ToString().ToLower())
            {
                command = ChestCommand.Заблокировать;
                correct = true;
            }
            else if (com.ToLower() == ChestCommand.Разблокировать.ToString().ToLower())
            {
                command = ChestCommand.Разблокировать;
                correct = true;
            }
            else if (com.ToLower() == ChestCommand.Открыть.ToString().ToLower())
            {
                command = ChestCommand.Открыть;
                correct = true;
            }
            else if (com.ToLower() == ChestCommand.Закрыть.ToString().ToLower())
            {
                command = ChestCommand.Закрыть;
                correct = true;
            }
        }
        return command;
        
    }
}
