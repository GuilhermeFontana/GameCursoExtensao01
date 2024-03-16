using Framework.Framework.Classes;

namespace GameProject.Scenarios.Headquarters {
    internal class HeadquartersJail : Scene {
        public HeadquartersJail() {

            Add(@"Você foi preso por isso.




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
            Add("Any) Voltar para cidade");
        }

        public override void ProcessPlayerAction() {
            Move(new City());
        }
    }
}
