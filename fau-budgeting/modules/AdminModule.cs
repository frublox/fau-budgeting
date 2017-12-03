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
                var data = getBudgetRequestData();
                return View["admin", data];
            };
        }
        
        BudgetRequestData getBudgetRequestData()
        {
            string connStr = ConfigurationManager.ConnectionStrings[0].ConnectionString;

            BudgetingDbDataContext db = new BudgetingDbDataContext(connStr);

            var queryUnreviewed =
                from request in db.BudgetRequests
                where request.Status == "New"
                select request;

            var queryReviewed =
                from request in db.BudgetRequests
                where request.Status == "Awaiting Resubmission"
                select request;

            var queryAccepted =
                from request in db.BudgetRequests
                where request.Status == "Accepted"
                select request;

            var queryApproved =
                from request in db.BudgetRequests
                where request.Status == "Approved"
                select request;

            var queryApprovedBudget =
                from global in db.Globals
                select global;

            BudgetRequestData data = new BudgetRequestData
            {
                Unreviewed = queryUnreviewed.ToList(),
                Reviewed = queryReviewed.ToList(),
                Accepted = queryAccepted.ToList(),
                Approved = queryApproved.ToList(),
                ApprovedBudget = queryApprovedBudget.First().ApprovedBudget
            };

            return data;
        }
    }
}