using System.ComponentModel.DataAnnotations;

namespace Barinak_Sistemi.Models
{
    public class DropAnimal
    {
        [Key]
        public int DropAId { get; set; }
        public string DropAType { get; set; }
        public string DropAName { get; set; }
        public int DropAAge { get; set; }
        public string DropAGender { get; set; }
        public string DropADescription { get; set; }
    }
}
