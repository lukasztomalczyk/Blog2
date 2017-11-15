
using DAL.Models;
using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBlogRepository _blogRepository;

        public HomeController(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        public IActionResult Index()
        {
           return View("Views/Home/Home.cshtml", _blogRepository.GetAll());
        }

        [HttpPost]
        public Post Add ([FromBody] Post _newPost)
        {
            _blogRepository.Add(_newPost);
            _blogRepository.Save();
            return _newPost;
        }
    }
}