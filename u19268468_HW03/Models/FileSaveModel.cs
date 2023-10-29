using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u19268468_HW03.Models
{
    public class FileSaveModel
    {
        [AllowHtml]
        //file name
        public string FileName { get; set; }

        //info
        public string Information { get; set; }

        //file type
        public string FileType { get; set; }

       
    }
}