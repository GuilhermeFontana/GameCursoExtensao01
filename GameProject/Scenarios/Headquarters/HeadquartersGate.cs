using Framework.Framework.Classes;

namespace GameProject.Scenarios.Headquarters {
    internal class HeadquartersGate : Scene {

        public HeadquartersGate() {

            Add(@"Chegamos no quartel
 _____________________________________________________________________________
/        ___   ___   ___   ___   ___   ___   ___   ___   ___   ___ ___       \
| |       |___| |___| |___| |___| |___| |___| |___| |___| |___| |___|       | |
| |     _____________________________________________________________       | |
| |    |                         _.-=-._                             |      | |
| |    |                      .-`  |   `'-..                         |      | |
| |    |             _  .=.  _|_   |     _|_                        |      | |
| |    |          .--'`|   |-`  |  |    |   |`'--.                   |      | |
| |    |        .'   __|___|    |  |    |___|__   `.                 |      | |
| |    |       /   .`      |    |  |    |       `.   \                |      | |
| |    |      |   /         \   |  |   /         \   |               |      | |
| |    |      \  |           |  |  |  |           |  /               |      | |
| |    |       \  `-._    _.-`   |   `-._    _.-`  /                |      | |
| |    |        `.    `--`    .'|`.    `--`    .`                 |      | |
| |    |          `-._      _.-`  `-._      _.-`                   |      | |
| |    |              `-.-`          `-.-`                        |      | |
| |_________________________________________________________________________| |");

            Add("");
            Add("1) Invadir    2) Mostrar credenciais      3) Voltar para cidade     E) Backpack");
        }

        public override void ProcessPlayerAction() {
            while(!ValidatePlayerAction())
                RequestPlayerAction();

            switch(currentPlayerAction) {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Move(new HeadquartersJail());

                break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Move(new HeadquartersOffice());

                break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:

                    Move(new City());

                break;
                case ConsoleKey.E:

                    Move(new Backpack(this));

                break;
            }
        }

        public override bool ValidatePlayerAction() {
            List<ConsoleKey> keys = new List<ConsoleKey>() { 
                ConsoleKey.D1, ConsoleKey.NumPad1, 
                ConsoleKey.D2, ConsoleKey.NumPad2, 
                ConsoleKey.D3, ConsoleKey.NumPad3 ,
                ConsoleKey.E
            };

            return keys.Contains(currentPlayerAction);
        }
    }
}
