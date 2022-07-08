

using CreateToManyRelationsAndAddToSQL.Properties.DAL;
using CreateToManyRelationsAndAddToSQL.Properties.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

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
            List<Book> books = _context.Books
            .Include(b=>b.Images)
            .Include(b=>b.BookAuthors)
            .ThenInclude(a=>a.Author).ThenInclude(s=>s.SocialAccount.Instagram).ToList();
            return View(books);
        }
    }
}
