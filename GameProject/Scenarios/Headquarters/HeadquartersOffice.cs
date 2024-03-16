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
            Add("1) Mostrar autorização    2) Insultar ele");
        }

        public override void ProcessPlayerAction() {
            switch(currentPlayerAction) {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                Console.WriteLine("Entrou");

                break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                Move(new HeadquartersJail());

                break;
            }
        }
    }
}
