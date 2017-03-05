using System;
using System.Collections.Generic;

namespace ALittleBigBlog.Models
{
    public sealed class Post
    {
        public long PostId { get; set; }

        public long? UserId { get; set; }

        public string Header { get; set; }

        public string Outline { get; set; }

        public string Content { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime DateModified { get; set; }

        public ICollection<PostTag> PostTags { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
