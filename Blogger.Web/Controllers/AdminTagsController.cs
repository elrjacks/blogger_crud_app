using Blogger.Web.Data;
using Blogger.Web.Models.Domain;
using Blogger.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blogger.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BloggerDbContext bloggerDbContext;


        //constructor injection
        public AdminTagsController(BloggerDbContext bloggerDbContext)
        {
            this.bloggerDbContext = bloggerDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest) 
        {
            //convert the a domain.tag model 
            //mapping the AddTagRequest to Tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };
            
            bloggerDbContext.Tags.Add(tag);
            bloggerDbContext.SaveChanges();
           
            return View("Add");
        }
    }
}
