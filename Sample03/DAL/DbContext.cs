using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample03.DAL
{
    public class SampleDbContext
    {
        static SampleDBEntities Db;
        public static SampleDBEntities Current
        {
            get{
                if(System.Web.HttpContext.Current.Session["SampleDbContext"] == null)
                {
                    Db = new SampleDBEntities();
                    System.Web.HttpContext.Current.Session["SampleDbContext"] = Db;
                }
                return Db;
            }
        }
    }
}