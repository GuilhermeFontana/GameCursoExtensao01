namespace GameProject.Framework.Classes {
    
    //Singleton
    internal sealed class Player {

        private static Player _instance;
        public double Health { get; set; }
        public double Money { get; set; }
        public Backpack Backpack;

        private string _name;
        public string Name {
            get {
                if(String.IsNullOrEmpty(_name))
                    _name = "Hero";

                return _name;
            }
            set {
                if(String.IsNullOrEmpty(_name))
                    _name = value;
            } 
        }

        private Player() {
            Health = 100.0;
            Money = 500.0;
            Backpack = new Backpack();
        }

        public static Player GetInstance () {
            if(_instance is null)
                _instance = new Player();

            return _instance;
        }

        public override string ToString() {
            return $"Player: {Name} - Health: {Health} - Money: ${Money}";
        }
    }
}
