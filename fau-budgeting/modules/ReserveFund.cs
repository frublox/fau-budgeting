using Nancy;
using Nancy.ModelBinding;
using System.Web.Script.Serialization;
using System;



namespace fau_budgeting
{
    public class ReserveFund : NancyModule
    {
        public ReserveFund()
        {
            Get["/reserve-fund"] = _ =>
            {
                int? id = Request.Query["id"];

                if (id != null)
                {
                    return View["forms/ReserveFund", id];
                }
                else
                {
                    return View["forms/ReserveFund"];
                }
            };

            Post["/reserve-fund-submit"] = _ =>
            {
                Reserve_Request request = this.Bind<Reserve_Request>();

                var json = new JavaScriptSerializer().Serialize(request);

                var budgetRequest = new BudgetRequest
                {
                    Date = DateTime.Now,
                    Status = "New",
                    OrganizationId = 1,
                    RequestType = "Reserve Fund",
                    RequestData = json
                };

                if (request.RequestId != null)
                {
                    Database.UpdateRequestData((int)request.RequestId, budgetRequest.RequestData);
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