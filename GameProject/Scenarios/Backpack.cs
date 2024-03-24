using Framework.Framework.Classes;
using GameProject.Framework.Classes;

namespace GameProject.Scenarios {
    internal class Backpack : Scene {
        private Scene CurrentScene;

        public Backpack(Scene CurrentScene) {
            this.CurrentScene = CurrentScene;

            Player Player = Player.GetInstance();

            Add(@"

BACKPACK");

            Add("(press any key to exit)");
            Add("");
            Add("");

            if (Player.Backpack.Itens.Count > 0)
                foreach(Item item in Player.Backpack.Itens)
                    Add($"{item}");
            else
                Add($"Empty");
        }

        public override void ProcessPlayerAction() {
            Move(CurrentScene);
        }

        public override bool ValidatePlayerAction() { return true; }
    }
}
