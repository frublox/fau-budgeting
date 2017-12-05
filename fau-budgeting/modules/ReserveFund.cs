using Nancy;
using Nancy.ModelBinding;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;



namespace fau_budgeting
{
    public class Reserve_Request
    {
        public string res_fund_supp_smarttag { get; set; }
        public string res_fund_supp_account_name { get; set; }
        public string transferin1 { get; set; }
        public int transferin2 { get; set; }
        public string transferin3 { get; set; }
        public int transferin4 { get; set; }
        public string transferin5 { get; set; }
        public int transferin6 { get; set; }
        public int equipment { get; set; }
        public int improvements { get; set; }
        public int contingencies1 { get; set; }
        public string contingencies2 { get; set; }
        public int contingencies3 { get; set; }
        public string contingencies4 { get; set; }
        public int contingencies5 { get; set; }
        public string contingencies6 { get; set; }
        public int contingencies7 { get; set; }
        public string contingencies8 { get; set; }
        public int contingencies9 { get; set; }
        public string transferout1 { get; set; }
        public int transferout2 { get; set; }
        public string transferout3 { get; set; }
        public int transferout4 { get; set; }
        public string transferout5 { get; set; }
        public int transferout6 { get; set; }

        public int res_fund_supp_transfers_in_approved { get; set; }
        public int res_fund_supp_transfers_in_request { get; set; }
        public int res_fund_supp_total_transfer_in_approved { get; set; }
        public int res_fund_supp_total_transfer_in_request {get; set;}
        public int res_fund_supp_expenses_approved { get; set; }
        public int res_fund_supp_expenses_request { get; set; }
        public int res_fund_supp_transfers_out_approved { get; set; }
        public int res_fund_supp_transfers_out_request { get; set; }
        public int res_fund_supp_overhead_approved { get; set; }
        public int res_fund_supp_overhead_request { get; set; }
        public int res_fund_supp_total_exp_approved { get; set; }
        public int res_fund_supp_total_exp_request { get; set; }
        public int res_fund_supp_transfer_in_requested { get; set; }
        public string res_fund_supp_transfer_in_justification { get; set; }
        public int res_fund_supp_equipment_budget { get; set; }
        public int res_fund_supp_improvements_budget { get; set; }
        public int res_fund_supp_contingencies_budget { get; set; }
        public int res_fund_supp_other_budget { get; set; }
        public int res_fund_supp_total_budget { get; set; }
        public int res_fund_supp_equipment_requested { get; set; }
        public string res_fund_supp_equipment_justification { get; set; }
        public int res_fund_supp_improvements_requested { get; set; }
        public string res_fund_supp_improvements_justification { get; set; }
        public int res_fund_supp_contingencies_requested { get; set; }
        public string res_fund_supp_contingencies_justification { get; set; }
        public int res_fund_supp_other_requested { get; set; }
        public string res_fund_supp_other_justification { get; set; }
        public int res_fund_supp_transfer_out_requested { get; set; }
        public string res_fund_supp_transfer_out_justification { get; set; }

    }




    public class ReserveFund : NancyModule
    {
        public ReserveFund()
        {

                     

            Get["/reserve-fund"] = _ => View["/forms/ReserveFund"];

            Post["/reserve-fund-submit"] = _ =>
            {
                Reserve_Request input = this.Bind<Reserve_Request>();

                var json = new JavaScriptSerializer().Serialize(input);
                //var jsonStr = JSON.stringify(jsonVar);

                //connects to DB
                string connStr = ConfigurationManager.ConnectionStrings[0].ConnectionString;
                BudgetingDbDataContext db = new BudgetingDbDataContext(connStr);

                //
                var revenueRequest = new BudgetRequest
                {
                    Date = DateTime.Now,
                    Status = "New",
                    OrganizationId = 1,
                    RequestType = "Reserve Fund",
                    RequestData = json
                };


                //submit request
                db.BudgetRequests.InsertOnSubmit(revenueRequest);

                try
                {
                    //submit changes
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    db.SubmitChanges();
                }

                return Response.AsRedirect("/organization");
            };

            

        }
    }
}