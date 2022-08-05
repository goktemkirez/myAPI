using System.ComponentModel.DataAnnotations;

namespace myAPI.EntityLayer.Concrete
{
    public class ExperienceResponsibility
    {
        [Key]
        public int ID { get; set; }
        public string? Responsibility { get; set; }
        public int? ExperienceID { get; set; }
    }
}
