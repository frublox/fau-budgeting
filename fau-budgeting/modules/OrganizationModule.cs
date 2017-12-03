using Nancy;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace fau_budgeting.modules
{
    public class OrganizationModule : NancyModule
    {
        public OrganizationModule()
        {
            Get["/organization"] = _ =>
            {
                return View["organization", Database.GetBudgetRequests(1)];
            };
        }
    }
}