using System.ComponentModel.DataAnnotations;

namespace Barinak_Sistemi.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public string AnimalType { get; set;}
        public string AnimalGender { get; set; }
        public int AnimalAge { get; set; }
        public string AnimalDescription { get; set; }

    }
}
