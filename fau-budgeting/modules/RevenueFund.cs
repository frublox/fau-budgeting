using Nancy;
using Nancy.ModelBinding;
using System.Web.Script.Serialization;



namespace fau_budgeting
{
    public class Revenue_Request
    {
        public string rev_fund_smarttag { get; set; }
        public string rev_fund_account_name { get; set; }
        public string rev_fund_generating_event_1 { get; set; }
        public int rev_fund_generating_event_request_1 { get; set; }
        public string rev_fund_generating_event_2 { get; set; }
        public int rev_fund_generating_event_request_2 { get; set; }
        public string rev_fund_generating_event_3 { get; set; }
        public int rev_fund_generating_event_request_3 { get; set; }
        public string rev_fund_generating_event_4 { get; set; }
        public int rev_fund_generating_event_request_4 { get; set; }
        public string rev_fund_generating_event_5 { get; set; }
        public int rev_fund_generating_event_request_5 { get; set; }
        public string rev_fund_generating_event_6 { get; set; }
        public int rev_fund_generating_event_request_6 { get; set; }
        public string rev_fund_transfers_in_1 { get; set; }
        public int rev_fund_transfers_in_request_1 { get; set; }
        public string rev_fund_transfers_in_2 { get; set; }
        public int rev_fund_transfers_in_request_2 { get; set; }
        public string rev_fund_transfers_in_3 { get; set; }
        public int rev_fund_transfers_in_request_3 { get; set; }
        public int rev_fund_support_request { get; set; }
        public int rev_fund_food_request { get; set; }
        public int rev_fund_programs_request { get; set; }
        public int rev_fund_travel_request { get; set; }
        public string rev_fund_services_1 { get; set; }
        public int rev_fund_services_request_1 { get; set; }
        public string rev_fund_services_2 { get; set; }
        public int rev_fund_services_request_2 { get; set; }
        public string rev_fund_services_3 { get; set; }
        public int rev_fund_services_request_3 { get; set; }
        public string rev_fund_services_4 { get; set; }
        public int rev_fund_services_request_4 { get; set; }
        public string rev_fund_transfer_out_1 { get; set; }
        public int rev_fund_transfer_out_request_1 { get; set; }
        public string rev_fund_transfer_out_2 { get; set; }
        public int rev_fund_transfer_out_request_2 { get; set; }
        public string rev_fund_transfer_out_3 { get; set; }
        public int rev_fund_transfer_out_request_3 { get; set; }
        public string rev_fund_ops_smarttag { get; set; }
        public string rev_fund_ops_account_name { get; set; }

        public string rev_fund_ops_position_1 { get; set; }
        public string rev_fund_ops_title_1 { get; set; }
        public int rev_fund_ops_rate_1 { get; set; }
        public int rev_fund_ops_hours_1 { get; set; }
        public int rev_fund_ops_weeks_1 { get; set; }
        public int rev_fund_ops_people_1 { get; set; }

        public string rev_fund_ops_position_2 { get; set; }
        public string rev_fund_ops_title_2 { get; set; }
        public int rev_fund_ops_rate_2 { get; set; }
        public int rev_fund_ops_hours_2 { get; set; }
        public int rev_fund_ops_weeks_2 { get; set; }
        public int rev_fund_ops_people_2 { get; set; }

        public string rev_fund_ops_position_3 { get; set; }
        public string rev_fund_ops_title_3 { get; set; }
        public int rev_fund_ops_rate_3 { get; set; }
        public int rev_fund_ops_hours_3 { get; set; }
        public int rev_fund_ops_weeks_3 { get; set; }
        public int rev_fund_ops_people_3 { get; set; }

        public string rev_fund_ops_position_4 { get; set; }
        public string rev_fund_ops_title_4 { get; set; }
        public int rev_fund_ops_rate_4 { get; set; }
        public int rev_fund_ops_hours_4 { get; set; }
        public int rev_fund_ops_weeks_4 { get; set; }
        public int rev_fund_ops_people_4 { get; set; }

        public string rev_fund_ops_position_5 { get; set; }
        public string rev_fund_ops_title_5 { get; set; }
        public int rev_fund_ops_rate_5 { get; set; }
        public int rev_fund_ops_hours_5 { get; set; }
        public int rev_fund_ops_weeks_5 { get; set; }
        public int rev_fund_ops_people_5 { get; set; }

        public string rev_fund_ops_position_6 { get; set; }
        public string rev_fund_ops_title_6 { get; set; }
        public int rev_fund_ops_rate_6 { get; set; }
        public int rev_fund_ops_hours_6 { get; set; }
        public int rev_fund_ops_weeks_6 { get; set; }
        public int rev_fund_ops_people_6 { get; set; }

        public string rev_fund_ops_position_7 { get; set; }
        public string rev_fund_ops_title_7 { get; set; }
        public int rev_fund_ops_rate_7 { get; set; }
        public int rev_fund_ops_hours_7 { get; set; }
        public int rev_fund_ops_weeks_7 { get; set; }
        public int rev_fund_ops_people_7 { get; set; }

        public string rev_fund_ops_position_8 { get; set; }
        public string rev_fund_ops_title_8 { get; set; }
        public int rev_fund_ops_rate_8 { get; set; }
        public int rev_fund_ops_hours_8 { get; set; }
        public int rev_fund_ops_weeks_8 { get; set; }
        public int rev_fund_ops_people_8 { get; set; }

        public string rev_fund_ops_position_9 { get; set; }
        public string rev_fund_ops_title_9 { get; set; }
        public int rev_fund_ops_rate_9 { get; set; }
        public int rev_fund_ops_hours_9 { get; set; }
        public int rev_fund_ops_weeks_9 { get; set; }
        public int rev_fund_ops_people_9 { get; set; }

        public string rev_fund_ops_position_10 { get; set; }
        public string rev_fund_ops_title_10 { get; set; }
        public int rev_fund_ops_rate_10 { get; set; }
        public int rev_fund_ops_hours_10 { get; set; }
        public int rev_fund_ops_weeks_10 { get; set; }
        public int rev_fund_ops_people_10 { get; set; }

        public string rev_fund_ops_position_11 { get; set; }
        public string rev_fund_ops_title_11 { get; set; }
        public int rev_fund_ops_rate_11 { get; set; }
        public int rev_fund_ops_hours_11 { get; set; }
        public int rev_fund_ops_weeks_11 { get; set; }
        public int rev_fund_ops_people_11 { get; set; }

        public string rev_fund_ops_position_12 { get; set; }
        public string rev_fund_ops_title_12 { get; set; }
        public int rev_fund_ops_rate_12 { get; set; }
        public int rev_fund_ops_hours_12 { get; set; }
        public int rev_fund_ops_weeks_12{ get; set; }
        public int rev_fund_ops_people_12 { get; set; }

        public string rev_fund_ops_position_13 { get; set; }
        public string rev_fund_ops_title_13 { get; set; }
        public int rev_fund_ops_rate_13 { get; set; }
        public int rev_fund_ops_hours_13 { get; set; }
        public int rev_fund_ops_weeks_13 { get; set; }
        public int rev_fund_ops_people_13 { get; set; }

        public string rev_fund_ops_position_14 { get; set; }
        public string rev_fund_ops_title_14 { get; set; }
        public int rev_fund_ops_rate_14 { get; set; }
        public int rev_fund_ops_hours_14 { get; set; }
        public int rev_fund_ops_weeks_14{ get; set; }
        public int rev_fund_ops_people_14 { get; set; }

        public string rev_fund_supp_smarttag { get; set; }
        public string rev_fund_supp_account_name { get; set; }
        public string rev_fund_supp_rev_approved { get; set; }
        public string rev_fund_supp_rev_request { get; set; }
        public string rev_fund_supp_transfers_in_approved { get; set; }
        public string rev_fund_supp_transfers_in_request { get; set; }
        public string rev_fund_supp_total_transfer_in_approved { get; set; }
        public string rev_fund_supp_total_transfer_in_request { get; set; }
        public string rev_fund_supp_ops_approved { get; set; }
        public string rev_fund_supp_ops_request { get; set; }
        public string rev_fund_supp_expenses_approved { get; set; }
        public string rev_fund_supp_expenses_request { get; set; } 
        public string rev_fund_supp_transfers_out_approved { get; set; }
        public string rev_fund_supp_transfers_out_request { get; set; }
        public string rev_fund_supp_overhead_approved { get; set; }
        public string rev_fund_supp_overhead_request { get; set; }
        public string rev_fund_supp_total_exp_approved { get; set; }
        public string rev_fund_supp_total_exp_request { get; set; }
        public string rev_fund_supp_rev_requested { get; set; }
        public string rev_fund_supp_rev_justification { get; set; }
        public string rev_fund_supp_transfer_in_requested { get; set; }
        public string rev_fund_supp_transfer_in_justification { get; set; }
        public string rev_fund_supp_ops_requested { get; set; }
        public string rev_fund_supp_ops_justification { get; set; }
        public int rev_fund_supp_support_budget { get; set; }
        public int rev_fund_supp_food_budget { get; set; }
        public int rev_fund_supp_services_budget { get; set; }
        public int rev_fund_supp_travel_budget { get; set; }
        public int rev_fund_supp_other_budget { get; set; }
        public int rev_fund_supp_total_budget { get; set; }
        public int rev_fund_supp_support_requested { get; set; }
        public int rev_fund_supp_support_justification { get; set; }
        public int rev_fund_supp_food_requested { get; set; }
        public int rev_fund_supp_food_justification { get; set; }
        public int rev_fund_supp_services_justification { get; set; }
        public int rev_fund_supp_travel_requested { get; set; }
        public string rev_fund_supp_travel_justification { get; set; }
        public int rev_fund_supp_other_requested { get; set; }
        public string rev_fund_supp_other_justification { get; set; }
        public int rev_fund_supp_transfer_out_requested { get; set; }
        public string rev_fund_supp_transfer_out_justification { get; set; }
    }

    public class RevenueFund : NancyModule
    {
        public RevenueFund()
        {
            Get["/revenue-fund"] = _ => View["RevenueFund"];

            Post["/revenue-fund-submit"] = _ =>
            {
                Revenue_Request request = this.Bind<Revenue_Request>();
                var json = new JavaScriptSerializer().Serialize(request);

                return View["RevenueFund"];
            };
        }
    }
}