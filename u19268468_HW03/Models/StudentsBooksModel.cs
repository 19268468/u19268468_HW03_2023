using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using u19268468_HW03.Models;

namespace u19268468_HW03.Models
{
    public class StudentsBooksModel
    {
        // students - Students
        public IEnumerable<students> Students { get; set; }

        // borrows - Borrows
        public IEnumerable<borrows> Borrows { get; set; }

        //books - Books
        public IEnumerable<books> Books { get; set; }

        //types - Types
        public IEnumerable<types> Types { get; set; }

        //authors - Authors
        public IEnumerable<authors> Authors { get; set; }


    }
}