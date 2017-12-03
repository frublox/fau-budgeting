using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace fau_budgeting
{
    public class Database
    {
        public static AdminDashboardData GetAdminDashboardData()
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

            AdminDashboardData data = new AdminDashboardData
            {
                Unreviewed = queryUnreviewed.ToList(),
                Reviewed = queryReviewed.ToList(),
                Accepted = queryAccepted.ToList(),
                Approved = queryApproved.ToList(),
                ApprovedBudget = queryApprovedBudget.First().ApprovedBudget
            };

            return data;
        }

        public static List<BudgetRequest> GetBudgetRequests(int organizationId)
        {
            string connStr = ConfigurationManager.ConnectionStrings[0].ConnectionString;

            BudgetingDbDataContext db = new BudgetingDbDataContext(connStr);

            var query =
                from request in db.BudgetRequests
                where request.Organization.Id == organizationId
                select request;

            return query.ToList();
        }

        public static User GetUser(string email)
        {
            string connStr = ConfigurationManager.ConnectionStrings[0].ConnectionString;

            BudgetingDbDataContext db = new BudgetingDbDataContext(connStr);

            var query =
                from user in db.Users
                where user.Email == email
                select user;

            return query.FirstOrDefault();
        }
    }
}