using static AnimalInfo.Models.Cat;

namespace AnimalInfo.Models
{
    public class Cat : Animal, ICat
    {
        
            public int Id { get; set; }
            public string? ImageUrl { get; set; }
            public string? UID { get; set; }
        
    }
}
