using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Views.News
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }
    }
}