namespace Framework.Framework.Classes {
    internal abstract class Scene {
        private World World;
        private int Top;
        protected ConsoleKey currentPlayerAction;

        public Scene() {
            World = new World(20, 80);

            Top = 0;
        }

        public void Add(string text) {
            Top += World.Draw(Top, 0, text);
        }

        public void RequestPlayerAction() {
            currentPlayerAction = Console.ReadKey().Key;
            Console.WriteLine();
        }

        public void Show() {
            Console.WriteLine(World);

            RequestPlayerAction();
            ProcessPlayerAction();
        }

        public void Move(Scene scene) {
            Console.Clear();

            scene.Show();
        }

        public abstract void ProcessPlayerAction();
    }
}
