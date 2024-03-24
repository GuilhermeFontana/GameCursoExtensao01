using Framework.Framework.Classes;

namespace GameProject.Scenarios {
    internal class Workplace : Scene {
        public Workplace() {
        }

        public override void ProcessPlayerAction() {
            Move(new City());
        }

        public override bool ValidatePlayerAction() { return true; }
    }
}
