using Nancy;
using Nancy.ModelBinding;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;



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
                Reserve_Request input = this.Bind<Reserve_Request>();

                var json = new JavaScriptSerializer().Serialize(input);

                var revenueRequest = new BudgetRequest
                {
                    Date = DateTime.Now,
                    Status = "New",
                    OrganizationId = 1,
                    RequestType = "Reserve Fund",
                    RequestData = json
                };

                Database.CreateBudgetRequest(revenueRequest);

                return Response.AsRedirect("/organization");
            };

            

        }
    }
}