using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _blogRepository;

        public BlogController(IBlogRepository _blogRepository)
        {
            this._blogRepository = _blogRepository;
        }

        public IActionResult AddPost()
        {
            return View();
        }
    }
}