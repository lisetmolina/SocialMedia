using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public interface IPostRepository
    {
        Task GetPosts();
    }
}