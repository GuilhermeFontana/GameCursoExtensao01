using Framework.Framework.Classes;
using GameProject.Framework.Classes;

namespace GameProject.Scenarios {
    internal class PlayerCreation : Scene{
        public PlayerCreation () : base(true) {
            Add(@"Player Name (Hero): ");
        }

        public override void ProcessPlayerAction() {
            Player Player = Player.GetInstance();
            
            Console.SetCursorPosition(2, 6);
            string playerName = Console.ReadLine();

            Player.Name = playerName;

            Move(new City());
        }

        public override bool ValidatePlayerAction() { return true; }
    }
}
