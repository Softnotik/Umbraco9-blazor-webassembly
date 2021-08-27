using System.Threading.Tasks;
using WebApplication1.Shared.Models;

namespace WebApplication1.Shared.Services
{
    public interface IContentService
    {
        Task<Root> GetRoot();
    }
}