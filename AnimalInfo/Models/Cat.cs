using static AnimalInfo.Models.Cat;

namespace AnimalInfo.Models
{
    public class Cat : Animal, ICat
    {
            /// <summary>
            /// ID of the cat
            /// </summary>
            public int Id { get; set; }
            /// <summary>
            /// Image url of the cat, if there is one
            /// </summary>
            public string? ImageUrl { get; set; }
            /// <summary>
            /// UID in case of ID numbers getting messed up
            /// </summary>
            public string? UID { get; set; }
        
    }
}
