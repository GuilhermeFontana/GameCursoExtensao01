using Framework.Framework.Classes;
using GameProject.Scenarios;

namespace Framework.Scenarios {
    internal class Menu : Scene {

        public Menu() {
                         Add(@"
.               ▄██████▄     ▄████████   ▄▄▄▄███▄▄▄▄      ▄████████ 
               ███    ███   ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███ 
               ███    █▀    ███    ███ ███   ███   ███   ███    █▀  
              ▄███          ███    ███ ███   ███   ███  ▄███▄▄▄     
             ▀▀███ ████▄  ▀███████████ ███   ███   ███ ▀▀███▀▀▀     
               ███    ███   ███    ███ ███   ███   ███   ███    █▄  
               ███    ███   ███    ███ ███   ███   ███   ███    ███ 
               ████████▀    ███    █▀   ▀█   ███   █▀    ██████████ 

   ▄███████▄    ▄████████  ▄██████▄      ▄█    ▄████████  ▄████████     ███     
  ███    ███   ███    ███ ███    ███    ███   ███    ███ ███    ███ ▀█████████▄ 
  ███    ███   ███    ███ ███    ███    ███   ███    █▀  ███    █▀     ▀███▀▀██ 
  ███    ███  ▄███▄▄▄▄██▀ ███    ███    ███  ▄███▄▄▄     ███            ███   ▀ 
▀█████████▀  ▀▀███▀▀▀▀▀   ███    ███    ███ ▀▀███▀▀▀     ███            ███     
  ███        ▀███████████ ███    ███    ███   ███    █▄  ███    █▄      ███     
  ███          ███    ███ ███    ███    ███   ███    ███ ███    ███     ███     
 ▄████▀        ███    ███  ▀██████▀ █▄ ▄███   ██████████ ████████▀     ▄████▀   
               ███    ███           ▀▀▀▀▀▀                                      
");
            Add("");
            Add("1) Jogar   Other) Sair");
        }

        public override void ProcessPlayerAction() {
            switch(currentPlayerAction) {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                
                Move(new City());
                
                break;

                default:

                Environment.Exit(0);

                break;
            }
        }

        public override bool ValidatePlayerAction() { return true; }
    }
}
