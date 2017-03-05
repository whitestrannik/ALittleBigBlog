using System;
using System.Collections.Generic;

namespace ALittleBigBlog.Models
{
    public class Comment
    {
        public long CommentId { get; set; }

        public long? UserId { get; set; }

        public string Header { get; set; }

        public string Outline { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime DateModified { get; set; }

        public long? PostId { get; set; }
        public Post Post { get; set; }

        public long? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }

        public ICollection<Comment> Replies { get; set; }
    }
}
