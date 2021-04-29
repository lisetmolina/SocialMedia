using Microsoft.AspNetCore.Mvc;
using SocialMedia.Infrastructure;
using SocialMedia.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace SociaLMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        
     
        [HttpGet]   
        public Task<IActionResult> GetPosts()
        {

            var posts = await _postRepository.GetPosts();
            return Ok(posts);
        }
    }
}