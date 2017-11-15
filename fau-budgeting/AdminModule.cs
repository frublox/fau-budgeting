using Nancy;
using System.Collections.Generic;

namespace fau_budgeting
{
    class BudgetRequest
    {
        public string Organization;
        public string Date;
        public string Status;
    }
    class BudgetRequestData
    {
        public List<BudgetRequest> Unreviewed;
        public List<BudgetRequest> Reviewed;
        public List<BudgetRequest> Accepted;
    }

    public class AdminModule : NancyModule
    {
        public AdminModule()
        {
            var data = new BudgetRequestData
            {
                Unreviewed = new List<BudgetRequest>
                {
                    new BudgetRequest()
                    {
                        Organization = "Blah",
                        Date = "Today",
                        Status = "New"
                    }
                },
                Reviewed = new List<BudgetRequest>
                {
                    new BudgetRequest()
                    {
                        Organization = "Foo",
                        Date = "Tomorrow",
                        Status = "Waiting on Resubmission"
                    }
                },
                Accepted = new List<BudgetRequest>
                {
                    new BudgetRequest()
                    {
                        Organization = "Bar",
                        Date = "Yesterday",
                        Status = "Accepted"
                    }
                }
            };

            Get["/admin"] = _ => View["admin", data];
        }
    }
}