using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fau_budgeting
{
    public class AdminDashboardData
    {
        public List<BudgetRequest> Unreviewed;
        public List<BudgetRequest> Reviewed;
        public List<BudgetRequest> Accepted;
        public List<BudgetRequest> Approved;
        public decimal ApprovedBudget;
    }
}