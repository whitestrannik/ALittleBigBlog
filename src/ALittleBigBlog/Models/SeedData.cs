using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALittleBigBlog.Models
{
    public class SeedData
    {
        private readonly MainDbContext _dbContext;

        public SeedData(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (!_dbContext.Posts.Any())
            {
                var post = new Post
                {
                    Content = "Content",
                    DateCreate = DateTime.Now,
                    DateModified = DateTime.Now,
                    Comments = new List<Comment>()
                        {
                            new Comment
                            {
                                DateCreate = DateTime.Now,
                                Header = "Comment header"
                            }
                        }
                };

                _dbContext.Posts.AddRange(post);

                _dbContext.Comments.AddRange(post.Comments);

                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
