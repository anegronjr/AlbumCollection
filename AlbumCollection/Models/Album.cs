using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string ImageUrl { get; set; }
        public virtual IEnumerable<Song> Songs { get; set; }
    }
}
