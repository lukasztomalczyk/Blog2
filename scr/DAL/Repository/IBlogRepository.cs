using DAL.Context;
using DAL.Interface;

namespace DAL.Repository
{
    public interface IBlogRepository : IGenericRepository<Post>
    {
    }
}