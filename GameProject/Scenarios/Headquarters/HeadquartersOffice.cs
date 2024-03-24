using Framework.Framework.Classes;

namespace GameProject.Scenarios.Headquarters {
    internal class HeadquartersOffice : Scene {
        public HeadquartersOffice() {

            Add(@"Fale com o soldado

::::==========:::::::::::::::::::::::::::::::::::::::::::::::::::::::
:::::::=========::::::.---------------.:::::::::::::::::::::::::::::::
:::=============::::::| .-----------. |:::::::::::::::::::::::::::::
::::==========::::::::| | === == == | |:::::::::::::::::::::::::::::::::
::::==========::::::::| | 260 ED OO | |:::::::::::::::::::::::::::::::
:::::::=========='::::| |  urgent!  | |:::::::::::::::::::::::::::::
:::===========::::::::| |___________| |::::::((;):::::::::::::::::::::
""""============""""""|___________oo__|"")"""";(""""""""""""""""""""""
  ==========='           ___)___(___,o  (   .---._
     ===========        |___________| 8  \  |TEA|_)    .+-------+.
  ===========                     o8o8    ) |___|    .' |_______| `.
    =============      __________8___    (          /  /         \  \
 |\`==========='/|   .'= --------- --`.   `.       |\ /           \ /|
 | '---------- - ' |  / ooooooooooooo  oo\   _\_     | '------------ - ' |
 | ______I_N______ | / oooooooooooo[] ooo\  |=|     | _______OUT_______ |");

            Add("");
            Add("1) Mostrar autorização    2) Insultar ele     E) Backpack");
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

                    Move(new HeadquartersJail());

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
                ConsoleKey.E
            };

            return keys.Contains(currentPlayerAction);
        }
    }
}
