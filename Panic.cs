using System;
namespace cosplore {
    internal class Panic {
        public Panic(string msg) {
            Console.Write(msg + " (Press any key to continue)");
            Console.ReadKey(true);
            Console.SetCursorPosition(0, Console.WindowHeight-Program.commandPos);
        }
    }
}
