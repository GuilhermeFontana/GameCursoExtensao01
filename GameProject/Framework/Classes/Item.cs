namespace GameProject.Framework.Classes {
    internal class Item {
        
        public string Name { get; set; }
        public double Health { get; set; }
        public int Durability { get; set; }

        public Item() { }

        public Item(string Name, double Health, int Durability) {
            this.Name = Name;
            this.Health = Health;
            this.Durability = Durability;
        }

        public override string ToString() {
            if (Health < 0)
                return $@"{Name} | Demage: {Health} | Durability: {Durability}";
            else
                return $@"{Name} | Cure: {Health} | Durability: {Durability}";
        }

    }
}
