using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Interface;

namespace DAL.Repository
{
    public interface IBlogRepository : IGenericRepository<Post>
    {

    }
}