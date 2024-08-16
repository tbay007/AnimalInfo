using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInfo.Models
{
    public interface ICat
    {
        /// <summary>
        /// ID for the cat
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// Image location if there is one
        /// </summary>
        string? ImageUrl { get; set; }
        /// <summary>
        /// User identification number, in case the IDs don't go chronologically
        /// </summary>
        string? UID { get; set; }
    }
}
