using AnotherWorld.Data.Enums;

namespace AnotherWorld.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public int StatBoost { get; set; }
        public int Damage { get; set; } // For weapons
        public int Defense { get; set; } // For armor
        public Hero Hero { get; set; }
    }

}
