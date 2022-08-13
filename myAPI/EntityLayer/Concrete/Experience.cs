using System.ComponentModel.DataAnnotations;

namespace myAPI.EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        public string? Company { get; set; }
        public string? Date { get; set; }
        public string? Title { get; set; }
        public string? Department { get; set; }
        public List<ExperienceResponsibility>? ExperienceResponsibilities { get; set; }
        public List<ExperienceProject>? ExperienceProjects { get; set; }
        public string? Website { get; set; }
        public int? Sorting { get; set; }
    }
}
