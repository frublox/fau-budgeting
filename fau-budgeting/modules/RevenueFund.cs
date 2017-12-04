using Nancy;
using Nancy.ModelBinding;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;



namespace fau_budgeting
{
    public class RevenueFund : NancyModule
    {
        public RevenueFund()
        {
            Get["/revenue-fund"] = _ =>
            {
                int? id = Request.Query["id"];

                if (id != null)
                {
                    return View["forms/RevenueFund", id];
                }
                else
                {
                    return View["forms/RevenueFund"];
                }
            };

            Post["/revenue-fund-submit"] = _ =>
            {
                //binds fields from form
                Revenue_Request request = this.Bind<Revenue_Request>();

                //converts to a string
                var json = new JavaScriptSerializer().Serialize(request);
                
                var revenueRequest = new BudgetRequest
                {
                    Date = DateTime.Now,
                    Status = "New",
                    OrganizationId = 1,
                    RequestType = "Revenue Fund",
                    RequestData = json
                };

                Database.CreateBudgetRequest(revenueRequest);

                return Response.AsRedirect("/organization");
            };
        }
    }
}