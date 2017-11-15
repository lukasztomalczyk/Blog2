using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class BlogRepository : GenericRepository<Post>, IBlogRepository
    {
        public BlogRepository(ApplicationDbContext context) : base(context)
        {
        }
        public override Post Add(Post t)
        {
            _context.Posts.Add(t);
            return t;
        }


    }
}