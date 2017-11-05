using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Context;

namespace DAL.Repository
{
    public class BlogRepository : GenericRepository<Post>
    {
        public BlogRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}