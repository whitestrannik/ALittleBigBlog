using System;
using System.Collections.Generic;

namespace ALittleBigBlog.Models
{
    public sealed class Post
    {
        public long? Id { get; set; }

        public long? UserId { get; set; }

        public string Header { get; set; }

        public string Outline { get; set; }

        public string Content { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime DateModified { get; set; }

        ICollection<Tag> Tags { get; set; }

        ICollection<Comment> Comments { get; set; }
    }
}
