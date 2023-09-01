using AnotherWorld.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnotherWorld.Data.Entities
{
    public class Hero
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public int Vitality { get; set; }
        public int Strength { get; set; }
        public int Magic { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
