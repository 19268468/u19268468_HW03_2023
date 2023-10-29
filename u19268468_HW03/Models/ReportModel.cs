using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u19268468_HW03.Models
{
    public class ReportModel
    {
        [AllowHtml]
        public string Content { get; set; }

        public string Extension { get; set; }

        public string FileName { get; set; }
    }
}