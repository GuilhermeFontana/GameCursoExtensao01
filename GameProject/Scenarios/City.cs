using Framework.Framework.Classes;
using GameProject.Scenarios.Headquarters;


namespace GameProject.Scenarios {
    internal class City : Scene {
        public City() {
            Add(@"Você esta na cidade. Ela é fria como Gelo

 .             .        .     .     |--|--|--|--|--|--|  |===|==|   /    i
        .            ______________|__|__|__|__|__|_ |  |===|==|  *  . /=\
__ *            .   /______________________________|-|  |===|==|       |=|  .
__|  .      .   .  //______________________________| :----------------------.
__|   /|\      _|_|//       ooooooooooooooooooooo  |-|                      |
__|  |/|\|__   ||l|/,-------8                   8 -| |                      |
__|._|/|\|||.l |[=|/,-------8                   8 -|-|                      |
__|[+|-|-||||li|[=|---------8                   8 -| |                      |
_-----.|/| //:\_[=|\`-------8                   8 -|-|                      |
 /|  /||//8/ :  8_|\`------ 8ooooooooooooooooooo8 -| |                      |
/=| //||/ |  .  | |\\_____________  ____  _________|-|                      |
==|//||  /   .   \ \\_____________ |X|  | _________| `---==------------==---'
==| ||  /         \ \_____________ |X| \| _________|     ||            ||
==| |~ /     .     \
LS|/  /             \______________________________________________________");

            Add("");
            Add("1) Entrar na cidade    2) Ir para os quarteis");
        }

        public override void ProcessPlayerAction() {
            switch(currentPlayerAction) {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                Console.WriteLine("Entrou");

                break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                Move(new HeadquartersGate());

                break;
            }
        }
    }
}
