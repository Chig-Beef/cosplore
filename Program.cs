using System;
using System.Linq;
namespace cosplore {
internal class Program {
    private static string[] validCommands = new string[] {
        "q",
    };
    private static string curCommand;
    public static readonly int commandPos = 2;

    private static void Main(string[] args) {
        startScreen();
        curCommand = "";
        ConsoleKeyInfo keyInfo;
        char key;
        while (true) {
            keyInfo = Console.ReadKey(true);
            key = keyInfo.KeyChar;
            if (key == '\r') {
                if (curCommand.Length == 0) continue;
                
                string[] splitCommand = curCommand.Split(' ');
                
                if (!validCommands.Contains(splitCommand[0])) {
                    new Panic("Invalid Command.");
                    curCommand = "";
                    continue;
                }
                
                Commands.runCommand(splitCommand[0], splitCommand.Skip(1).ToArray());
            }
            else if (key == '\b') {
                if (curCommand.Length == 0) continue;
            }
            else {
                curCommand += key;
                Console.Write(key);
            }
        }
    }
    
    private static void startScreen() {
        Console.SetCursorPosition(Console.WindowWidth/2-10, 0);
        Console.Write("Welcome to Cosplore.");
    }
}
}
