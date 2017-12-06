using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace fau_budgeting
{
    public class Database
    {
        public static AdminDashboardData GetAdminDashboardData()
        {
            var db = GetDbContext();

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
            var db = GetDbContext();

            var query =
                from request in db.BudgetRequests
                where request.Organization.Id == organizationId
                select request;

            return query.ToList();
        }

        public static User GetUser(string email)
        {
            var db = GetDbContext();

            var query =
                from user in db.Users
                where user.Email == email
                select user;

            return query.FirstOrDefault();
        }

        public static BudgetRequest GetBudgetRequest(int id)
        {
            var db = GetDbContext();

            var query =
                from request in db.BudgetRequests
                where request.Id == id
                select request;

            return query.ToList().FirstOrDefault();
        }

        public static void AcceptBudgetRequest(int id)
        {
            var db = GetDbContext();

            var query =
                from request in db.BudgetRequests
                where request.Id == id
                select request;

            foreach (BudgetRequest request in query)
            {
                request.Status = "Accepted";
            }

            db.SubmitChanges();
        }

        public static void ApproveBudgetRequest(int id)
        {
            BudgetingDbDataContext db = GetDbContext();

            var query =
                from request in db.BudgetRequests
                where request.Id == id
                select request;

            foreach (BudgetRequest request in query)
            {
                request.Status = "Approved";
            }

            db.SubmitChanges();
        }

        public static void SendBackBudgetRequest(int id, string comments)
        {
            BudgetingDbDataContext db = GetDbContext();

            var query =
                from request in db.BudgetRequests
                where request.Id == id
                select request;

            foreach (BudgetRequest request in query)
            {
                request.Status = "Awaiting Resubmission";
                request.Comments = comments;
            }

            db.SubmitChanges();
        }

        private static BudgetingDbDataContext GetDbContext()
        {
            string connStr = ConfigurationManager.ConnectionStrings[0].ConnectionString;

            return new BudgetingDbDataContext(connStr);
        }

        public static void ResubmitBudgetRequest(int id, string requestData)
        {
            var db = GetDbContext();

            var query =
                from request in db.BudgetRequests
                where request.Id == id
                select request;

            foreach (BudgetRequest request in query)
            {
                request.Status = "New";
                request.RequestData = requestData;
            }

            db.SubmitChanges();
        }

        public static void CreateBudgetRequest(BudgetRequest budgetRequest)
        {
            var db = GetDbContext();

            db.BudgetRequests.InsertOnSubmit(budgetRequest);

            db.SubmitChanges();
        }

        public static void UpdateRequestData(int id, string requestData)
        {
            var db = GetDbContext();

            var query =
                from request in db.BudgetRequests
                where request.Id == id
                select request;

            foreach (var request in query)
            {
                request.Status = "New";
                request.RequestData = requestData;
            }

            db.SubmitChanges();
        }

        public static bool BudgetRequestExists(int id)
        {
            var db = GetDbContext();

            var query =
                from request in db.BudgetRequests
                where request.Id == id
                select request;

            return query.ToList().Count > 0;
        }

        
    }
}