using Framework.Framework.Classes;
using GameProject.Framework.Classes;

namespace GameProject.Scenarios {

    internal class ShopItem {
        internal Item Item;
        internal double Price;

        internal ShopItem(Item Item, double Price) {
            this.Item = Item;
            this.Price = Price;
        }
    }

    internal class Shop : Scene {

        private List<ShopItem> itens = new List<ShopItem>() {
            new ShopItem(new Item("Granade", 0,0), 0),
            new ShopItem(new Item("Pistol", 0,0), 0),
            new ShopItem(new Item("Rifle", 0,0),  0),
            new ShopItem(new Item("Bandage", 0,0), 0),
            new ShopItem(new Item("Bulletproof Vest", 0,0), 0),
            new ShopItem(new Item("Bread", 0,0), 0 )
        };

        public Shop() {
            Add(@"

Bem vindo a nossa loja. 
Estes são nosso itens disponíveis");

            Add("");

            int i = 1;
            foreach(ShopItem item in itens)
                Add($"{i++}. {item.Item} | Price: {item.Price}");

        }

        public override void ProcessPlayerAction() {
            Player Player = Player.GetInstance();

            switch(currentPlayerAction) {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Player.Backpack.Itens.Add(itens[0].Item);
                    Player.Money -= itens[0].Price;

                break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Player.Backpack.Itens.Add(itens[1].Item);
                    Player.Money -= itens[1].Price;

                break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:

                    Player.Backpack.Itens.Add(itens[2].Item);
                    Player.Money -= itens[2].Price;

                break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:

                    Player.Backpack.Itens.Add(itens[3].Item);
                    Player.Money -= itens[3].Price;

                break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:

                    Player.Backpack.Itens.Add(itens[4].Item);
                    Player.Money -= itens[4].Price;

                break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
    
                    Player.Backpack.Itens.Add(itens[5].Item);
                    Player.Money -= itens[5].Price;

                break;
            }
                
            Move(new City());
        }

        public override bool ValidatePlayerAction() { return true; }

    }
}
