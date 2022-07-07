using CreateToManyRelationsAndAddToSQL.Properties.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CreateToManyRelationsAndAddToSQL.Properties.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;

        public HomeController(AppDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public IActionResult Index()
        {
            //string email = _config.GetSection("Login:Email").Value;
            //string password = _config.GetSection("Login:password").Value;
            return View();
        }
    }
}
