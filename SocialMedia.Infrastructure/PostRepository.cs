using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure
{
    public class PostRepository : IPostRepository
    {
      public async Task<IEnumerable<Post>> GetPosts()
        {
          var posts = Enumerable.Range(1,10).Select(x=> new Post 
          {
             PostId = x,
             Description = $"Description {x}",
             Date = DateTime.Now,
             Image = "https://misapis.com/{}",
             UserId = x*2
          });

            await Task.Delay(10);

            return posts;
        }

       
        }
    }

