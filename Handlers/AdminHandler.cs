using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripPreject2.Models.Siniflar
{
    public class AdminHandler
    {
        Context c = new Context();

        public List<Blog> ListBlog()
        {
            var degerler = c.Blogs.ToList();

            return degerler;
        }

    }
}