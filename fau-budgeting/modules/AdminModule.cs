using Nancy;
using System.Collections.Generic;

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