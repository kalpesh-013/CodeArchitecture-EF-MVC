using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rtisto.Web.Admin.Controllers
{
    public class AdminBaseController : Controller
    {
        public string ConnectionString { get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
        }
    }
}