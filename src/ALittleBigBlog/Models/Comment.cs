using System;
using System.Collections.Generic;

namespace ALittleBigBlog.Models
{
    public sealed class Comment
    {
        public long? Id { get; set; }

        public long? PostId { get; set; }

        public long? CommentId { get; set; }

        public long? UserId { get; set; }

        public string Header { get; set; }

        public string Outline { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime DateModified { get; set; }

        ICollection<Comment> Comments { get; set; }
    }
}
