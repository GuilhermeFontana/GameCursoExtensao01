using Framework.Framework.Classes;
using GameProject.Scenarios;

namespace Framework.Scenarios {
    internal class Menu : Scene {

        public Menu() {
            Add("1) Jogar");
            Add("0) Sair");
        }

        public override void ProcessPlayerAction() {
            switch(currentPlayerAction) {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
    
                    Move(new City());

                break;
                
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                Environment.Exit(0);
                break;
            }
        }
    }
}
