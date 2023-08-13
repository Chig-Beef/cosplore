namespace cosplore {
    class Panic {
        public Panic(string msg) {
            Console.Write(msg + " (Press any key to continue)");
            Console.ReadKey(true);
        }
    }
}
