using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class BlogController : Controller
    {

        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }
    }
}