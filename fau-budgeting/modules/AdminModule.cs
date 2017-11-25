using Nancy;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;

namespace fau_budgeting
{
    enum BudgetRequestStatus
    {
        New,
        InProgress,
        AwaitingResubmission,
        Approved
    }

    class HtmlProps
    {
        public string Class;
    }

    class BudgetRequest
    {
        public string Organization;
        public string Date;
        public BudgetRequestStatus Status;
        public string StatusText;
        public int Id;
        public HtmlProps Props;
    }

    class BudgetRequestData
    {
        public List<BudgetRequest> Unreviewed;
        public List<BudgetRequest> Reviewed;
        public List<BudgetRequest> Approved;
        public decimal ApprovedBudget;
    }

    public class AdminModule : NancyModule
    {
        public AdminModule()
        {
            // Example of data that would be obtained from DB call
            BudgetRequestData data = new BudgetRequestData
            {
                Unreviewed = new List<BudgetRequest>
                {
                    new BudgetRequest()
                    {
                        Organization = "Organization 1",
                        Date = "Today",
                        Status = BudgetRequestStatus.New,
                        StatusText = "New",
                        Id = 1,
                        Props = new HtmlProps()
                        {
                            Class = "status-new"
                        }
                    },
                    new BudgetRequest()
                    {
                        Organization = "Organization 4",
                        Date = "Today",
                        Status = BudgetRequestStatus.New,
                        StatusText = "In Progress",
                        Id = 4,
                        Props = new HtmlProps()
                        {
                            Class = "status-progress"
                        }
                    }
                },

                Reviewed = new List<BudgetRequest>
                {
                    new BudgetRequest()
                    {
                        Organization = "Organization 2",
                        Date = "Tomorrow",
                        Status = BudgetRequestStatus.AwaitingResubmission,
                        StatusText = "Awaiting Resubmission",
                        Id = 2,
                        Props = new HtmlProps()
                        {
                            Class = "status-awaiting"
                        }
                    }
                },

                Approved = new List<BudgetRequest>
                {
                    new BudgetRequest()
                    {
                        Organization = "Organization 3",
                        Date = "Yesterday",
                        Status = BudgetRequestStatus.Approved,
                        StatusText = "Approved",
                        Id = 3,
                        Props = new HtmlProps()
                        {
                            Class = "status-approved"
                        }
                    }
                },

                ApprovedBudget = 1500.30M
            };

            Get["/admin"] = _ => View["admin", data];
        }

        // TODO Implement actual db connection
        BudgetRequestData getDataStuff()
        {
            DataContext db = new DataContext("Server=localhost;Database=master;Trusted_Connection=True;");

            Table<BudgetRequest> requests = db.GetTable<BudgetRequest>();

            var queryUnreviewed =
                from request in requests
                where request.Status == BudgetRequestStatus.New
                select request;

            var queryReviewed =
                from request in requests
                where request.Status == BudgetRequestStatus.AwaitingResubmission
                select request;

            var queryApproved =
                from request in requests
                where request.Status == BudgetRequestStatus.Approved
                select request;

            BudgetRequestData data = new BudgetRequestData
            {
                Unreviewed = queryUnreviewed.ToList(),
                Reviewed = queryReviewed.ToList(),
                Approved = queryApproved.ToList()
            };

            return data;
        }
    }
}