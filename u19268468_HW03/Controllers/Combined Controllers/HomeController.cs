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
using PagedList;

namespace u19268468_HW03.Controllers
{
    public class HomeController : Controller
    {
        int numberElementPerPage = 10;
        private LibraryEntities db = new LibraryEntities();
        LibraryEntities db1 = new LibraryEntities();

        //Get: StudentsBooksCIndex
        public async Task<ActionResult> StudentsBooksCIndex(int pageIndex=1)
        {
            var viewModel = new StudentsBooksModel
            {
                Students = await db.students.Include(s => s.borrows).ToListAsync(),
                Books = await db.books.Include(s => s.types).Include(s => s.authors).ToListAsync()
            };


            List<StudentsBooksModel> studentlist = new List<StudentsBooksModel>();

            foreach (students record in db1.students.OrderByDescending(item => item.studentId))
            {
                if (record.gender.Equals("F") || record.gender.Equals("M"))
                {
                    students LibStudent = db1.students.FirstOrDefault(s => s.studentId == record.studentId);
                    if (LibStudent != null && record.gender != null) {
                        StudentsBooksModel s = new StudentsBooksModel
                        {
                            //id name surname birthdate gender class point
                            //StudentId = LibStudent.studentId,

                        };
                        studentlist.Add(s);
                    }
                }
            }

            return View(viewModel);
        }

        

        //GET: Students

        //GET: Books 
    }
}