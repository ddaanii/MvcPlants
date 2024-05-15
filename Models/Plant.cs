namespace MvcPlants.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImgPath { get; set; }
        public string? Family { get; set; }
        public string? Genus { get; set; }
        public string? Species { get; set; }
        public string? Origin { get; set; }
    }
}
