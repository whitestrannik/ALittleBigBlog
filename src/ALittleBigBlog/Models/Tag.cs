using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ALittleBigBlog.Models
{
    public sealed class Tag
    {
        public long TagId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }
}
