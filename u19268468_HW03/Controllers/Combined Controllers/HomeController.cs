using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using u19268468_HW03.Models;

namespace u19268468_HW03.Controllers
{
    public class HomeController : Controller
    {
        private LibraryEntities db = new LibraryEntities();

        //Get: StudentsBooksCIndex
        public async Task<ActionResult> StudentsBooksCIndex()
        {
            var viewModel = new StudentsBooksModel
            {
                Students = await db.students.Include(s => s.borrows).ToListAsync(),
                Books = await db.books.Include(s => s.types).Include(s => s.authors).ToListAsync()
            };
            return View(viewModel);
        }

        //GET: Students

        //GET: Books 
    }
}