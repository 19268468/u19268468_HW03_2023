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
    public class MaintainController : Controller
    {
        private LibraryEntities db = new LibraryEntities();


        // GET: Maintain
        public async Task<ActionResult> MaintainCIndex()
        {
            var viewModels = new MaintainModel()
            {
                // authors types borrows
                Authors = await db.authors.ToListAsync(),
                Types = await db.types.ToListAsync(),
                Borrows = await db.borrows.Include(b => b.students).Include(b => b.books).ToListAsync()
            };
            return View(viewModels);
        }
    }
}