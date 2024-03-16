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
            Add("1) Invadir    2) Mostrar credenciais      3) Voltar para cidade");
        }

        public override void ProcessPlayerAction() {
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
            }
        }
    }
}
