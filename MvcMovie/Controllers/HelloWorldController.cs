using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        /*
         *  program.cs 에서 설정된 패턴 id와 일치하면 PathVariable로 접근된다.
            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"); -- ? 는 선택사항이라는 표시
        */
        public IActionResult Welcome(string name, int numTimes = 3)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {id}"); // XSS 보호

            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
