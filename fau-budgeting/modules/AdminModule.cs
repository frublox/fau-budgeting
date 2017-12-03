using Nancy;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace fau_budgeting
{
    class BudgetRequestData
    {
        public List<BudgetRequest> Unreviewed;
        public List<BudgetRequest> Reviewed;
        public List<BudgetRequest> Accepted;
        public List<BudgetRequest> Approved;
        public decimal ApprovedBudget;
    }

    public class AdminModule : NancyModule
    {
        public AdminModule()
        {
            Get["/admin"] = _ =>
            {
                var data = Database.GetAdminDashboardData();
                return View["admin", data];
            };
        }
    }
}