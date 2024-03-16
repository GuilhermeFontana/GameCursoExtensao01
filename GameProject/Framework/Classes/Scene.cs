namespace Framework.Framework.Classes {
    internal abstract class Scene {

        #region Atributes

        private World World;
        private int Top;
        protected ConsoleKey currentPlayerAction;

        public Scene() {
            World = new World(20, 80);

            Top = 0;
        }

        #endregion Atributes

        #region Public Methods

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

        #endregion Public Methods

        #region Abstract Methods

        public abstract void ProcessPlayerAction();
        public abstract bool ValidatePlayerAction();

        #endregion Abstract Methods
    }
}
