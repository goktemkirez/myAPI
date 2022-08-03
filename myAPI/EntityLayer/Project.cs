using System.ComponentModel.DataAnnotations;

namespace myAPI.EntityLayer
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public string? VideoUrl { get; set; }
        public string? CodeUrl { get; set; }
        public string? LiveUrl { get; set; }

    }
}
