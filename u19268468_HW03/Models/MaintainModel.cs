using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u19268468_HW03.Models;

namespace u19268468_HW03.Models
{
    public class MaintainModel
    {
        //authors - Authors
        public IEnumerable<authors> Authors { get; set; }

        //types - Types
        public IEnumerable<types> Types { get; set; }

        //borrows - Borrows
        public IEnumerable<borrows> Borrows { get; set; }

        //books - Books
        public IEnumerable<books> Books { get; set; }

    }
}