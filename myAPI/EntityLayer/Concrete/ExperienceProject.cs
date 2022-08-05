using System.ComponentModel.DataAnnotations;

namespace myAPI.EntityLayer.Concrete
{
    public class ExperienceProject
    {
        [Key]
        public int ID { get; set; }
        public string? Project { get; set; }
        public int? ExperienceID { get; set; }
    }
}
