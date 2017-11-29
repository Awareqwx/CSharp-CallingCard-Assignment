using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("{fname}/{lname}/{age}/{color}")]
        public JsonResult Index(string fname, string lname, int age, string color)
        {
            return Json(new {
                FirstName = fname,
                LastName = lname,
                Age = age,
                FavoriteColor = color
            });
        }
    }
}