﻿using Nancy;

namespace fau_budgeting.modules
{
    public class ApiModule : NancyModule
    {
        public ApiModule() : base("/api")
        {
            Get["/budget-request-info"] = _ =>
            {
                int id = Request.Query["id"];
                return Database.GetBudgetRequest(id)?.RequestData;
            };
        }
    }
}