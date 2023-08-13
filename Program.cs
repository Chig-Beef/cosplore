using cosplore;
class Program {
    private static string[] validCommands = new string[] {
        "q",
    };
    private static string curCommand;

    private static void Main(string[] args) {
        curCommand = "";
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        char key = keyInfo.KeyChar;
        while (true) {
            if (curChar == '\r') {
                if (curCommand.Length == 0) continue;
                
                string[] splitCommand = curCommand.Split(' ');
                
                if (!validCommands.Contains(splitCommand[0])) {
                    new Panic("Invalid Command.);
                    curCommand = "";
                    continue;
                }
            }
            else if (curChar == '\b') {
                if (curCommand.Length == 0) continue;
            }
            else {
                curCommand += curChar;
            }
        }
    }
}
