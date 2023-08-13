using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
namespace Web.Controllers
{
    public class NewsController : Controller
    {
        MollaEntities db = new MollaEntities();
        // GET: News
        public ActionResult Index()
        {

            /*
            var ParentId = Guid.Parse("3EC92834-25A8-4C86-97C8-33E8FDE88A0F");

            var categories = db.Categories
                .Where(c => c.ParentId == ParentId)
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    Total = db.News_Category
                    .Where(n => n.CategoryId == c.Id).Count()
                }).ToList();
            */


            var targetParentId = Guid.Parse("3EC92834-25A8-4C86-97C8-33E8FDE88A0F");

            var categories = db.Categories
                            .Where(c => c.ParentId == targetParentId)
                            .Select(c => new
                            {
                                Id = c.Id,
                                Name = c.Name,
                                Total = db.News_Category.Count(n => n.CategoryId == c.Id)
                            })
                            .ToList();

            ViewBag.Categories = categories;
            return View();



            /*var targetParentId = Guid.Parse("3EC92834-25A8-4C86-97C8-33E8FDE88A0F");
            var categories = db.Categories
                            .Where(c => c.ParentId == targetParentId)
                            .Select(c => new
                            {
                                c.Id,
                                c.Name,
                                Total = db.News_Category.Count(n => n.CategoryId == c.Id)
                            })
                            .ToList();

            ViewBag.Categories = categories;
            return View();*/
            /*
                        var targetParentId = Guid.Parse("3EC92834-25A8-4C86-97C8-33E8FDE88A0F");

                        var categories = db.Categories
                                        .Where(c => c.ParentId == targetParentId)
                                        .Select(c => new
                                        {
                                            Id = c.Id,
                                            Name = c.Name,
                                            Total = db.News_Category.Count(n => n.CategoryId == c.Id)
                                        })
                                        .ToList();
            */

        }




    }
}