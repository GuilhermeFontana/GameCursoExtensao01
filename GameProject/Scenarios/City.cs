using Framework.Framework.Classes;
using GameProject.Framework.Classes;
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
            Add("1) Entrar     2) Ir para o quartel     3) Loja     4)Trabalhar      E) Backpack");
        }

        public override void ProcessPlayerAction() {
            while(!ValidatePlayerAction())
                RequestPlayerAction();

            switch(currentPlayerAction) {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                Console.WriteLine("Entrou");

                break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                Move(new HeadquartersGate());

                break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:

                Move(new Shop());

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
                ConsoleKey.D3, ConsoleKey.NumPad3, 
                ConsoleKey.D4, ConsoleKey.NumPad4,
                ConsoleKey.E
            };

            return keys.Contains(currentPlayerAction);
        }
    }
}
