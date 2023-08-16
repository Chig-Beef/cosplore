using System;
namespace cosplore {
    internal class Commands {
        public static void runCommand(string command, string[] args) {
            switch (command) {
                case "q":
                    quitProgram(args);
                    break;
                default:
                    new Panic("Invalid Command.");
                    break;
            }
        }

        private static Panic quitProgram(string[] args) {
            Console.Clear();
            Environment.Exit(0);
            return null;
        }
    }
}
