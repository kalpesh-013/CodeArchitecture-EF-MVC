using Rtisto.Core.Domain;
using Rtisto.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rtisto.Web.Admin.Controllers
{
    public class ArtistCategoriesController : AdminBaseController
    {
        ArtistCategoryService ArtistCategorySer;

        public ArtistCategoriesController()
        {
            ArtistCategorySer = new ArtistCategoryService(ConnectionString);
        }

        public ActionResult Index()
        {
            IList<ArtistCategory> artistCategoryList = ArtistCategorySer.GetAll();
            ViewBag.Name = artistCategoryList;
            return View(artistCategoryList);
        }
    }
}