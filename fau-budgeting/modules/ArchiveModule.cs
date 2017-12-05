using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fau_budgeting.modules
{
    public class ArchiveModule : NancyModule
    {
        public ArchiveModule()
        {
            Get["/archive"] = _ => View["archive"];
        }
    }
}