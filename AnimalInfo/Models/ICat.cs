using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInfo.Models
{
    public interface ICat
    {
        int Id { get; set; }
        string? ImageUrl { get; set; }
        string? UID { get; set; }
    }
}
