using Framework.Framework.Classes;
using GameProject.Framework.Classes;

namespace GameProject.Scenarios.Headquarters {
    internal class HeadquartersJail : Scene {

        public HeadquartersJail(string dialogue = "") {

            if(String.IsNullOrEmpty(dialogue.Trim()))
                dialogue = " Você foi preso por isso e perdeu todos os seus itens.";

            Add($@"{dialogue}
    


                               _ _.-'`-._ _
                               ;.'________'.;
     ________________________n.[____________].n______________________________
    |""""_""""_""""_""""_""""_""""_""""_""""_""""||==||==||==||""""_""""_""""_""""_""""_""""_""""_""""_""""_""""_""""]
    |""""""""""""""""""""""""""""""""""""""""""""""""""""||..||..||..||""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""|
    |LI LI LI LI LI LI LI LI LI||LI||LI||LI||LI LI LI LI LI LI LI LI LI LI LI|
    |.. .. .. .. .. .. .. .. ..||..||..||..||.. .. .. .. .. .. .. .. .. .. ..|
    |LI LI LI LI LI LI LI LI LI||LI||LI||LI||LI LI LI LI LI LI LI LI LI LI LI|
    |.. .. .. .. .. .. .. .. ..||..||..||..||.. .. .. .. .. .. .. .. .. .. ..|
    |LI LI LI LI LI LI LI LI LI||LI||LI||LI||LI LI LI LI LI LI LI LI LI LI LI|
    |.. .. .. .. .. .. .. .. ..||..||..||..||.. .. .. .. .. .. .. .. .. .. ..|
    |LI LI LI LI LI LI LI LI LI||LI||LI||LI||LI LI LI LI LI LI LI LI LI LI LI|
 ,,;;,;;;,;;,;;,;;,;;,;;,;;;,;;;,;;;,;;;,;;;,;;,;;;,;;;,;;,;;,;;,;;,;;,;;,;;,;;");

            Add("");
            Add("1) Pagar e voltar para cidade (- $100 | -0 Health)");
            Add("2) Tentar fugir (-$0 | -5 Health)");
        }

        public override void ProcessPlayerAction() {
            Player player = Player.GetInstance();
            player.Backpack.Itens = new List<Item>();

            switch(currentPlayerAction) {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    if(player.Money >= 100.0) { 
                        player.Money -= 100.0;
                        Move(new City());
                    }
                    else
                        Move(new HeadquartersJail("Você não tem dinheiro suficiente"));

                break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    player.Health -= 5;

                    if (new Random().Next(1, 100) == 33)
                        Move(new City());
                    else
                        Move(new HeadquartersJail("Sua fuga foi mal sucedida."));

                break;
            }
        }

        public override bool ValidatePlayerAction() {
            List<ConsoleKey> keys = new List<ConsoleKey>() {
                ConsoleKey.D1, ConsoleKey.NumPad1,
                ConsoleKey.D2, ConsoleKey.NumPad2
            };

            return keys.Contains(currentPlayerAction);
        }
    }
}
