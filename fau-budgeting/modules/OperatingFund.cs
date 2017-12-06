using Nancy;
using Nancy.ModelBinding;
using System.Web.Script.Serialization;
using System;

namespace fau_budgeting
{
    public class OperatingFund : NancyModule
    {
        public OperatingFund()
        {
            Get["/operating-fund"] = _ =>
            {
                int? id = Request.Query["id"];

                if (id != null)
                {
                    return View["forms/OperatingFund", id];
                }
                else
                {
                    return View["forms/OperatingFund"];
                }
            };

            Post["/operating-fund-submit"] = _ =>
            {
                Operating_Request request = this.Bind<Operating_Request>();
                var json = new JavaScriptSerializer().Serialize(request);

                //initialize fields of BudgetRequest instance
                var budgetRequest = new BudgetRequest
                {
                    Date = DateTime.Now,
                    Status = "New",
                    OrganizationId = 1,
                    RequestType = "Operating Fund",
                    RequestData = json
                };

                if (request.RequestId != null)
                {
                    Database.UpdateRequestData((int) request.RequestId, budgetRequest.RequestData);
                }
                else
                {
                    Database.CreateBudgetRequest(budgetRequest);
                }

                return Response.AsRedirect("/organization");
            };
        }
    }

}