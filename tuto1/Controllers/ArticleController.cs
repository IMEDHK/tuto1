using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tuto1.Models;

namespace tuto1.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        [Route("article/{id}/{title}")]
        public ActionResult Article(ArticleModels model)
        {
          //  var model = new ArticleModels
            //{
              //  ID = id,
                //TITLE = title

         //    };
        
            //title = !string.IsNullOrEmpty(title) ? ViewBag.ArticleTitle = title.Replace('-', ' ') : ViewBag.ArticleTitle = title.Replace('-', ' ');

        
            return View(model);
        }
        [Route("{(Type:regex(all|tous)}")]
        [Route("articles/all")]
        public ActionResult ArticleAll()
        {
            return View();

        }
    }
}