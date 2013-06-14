using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RottenMovies.Common;

namespace RottenMovies.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public string SuccessMessage
        {
            get { return ViewData[Constants.ItemKeys.SuccessMessage].ToString(); }
            set { ViewData[Constants.ItemKeys.SuccessMessage] = value; }
        }

        public string ErrorMessage
        {
            get { return ViewData[Constants.ItemKeys.ErrorMessage].ToString(); }
            set { ViewData[Constants.ItemKeys.ErrorMessage] = value; }
        }

        public void HandleException(Exception ex)
        {
            // throw the exception for now
            throw (ex);
        }
    }
}
