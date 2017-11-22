using Nancy;
using System.Collections.Generic;

namespace fau_budgeting
{
    public class RevFundSD
    {
        string SmartTag { get; set; }
        string AcctName { get; set; }
        struct Revenue
        {
            string[] Source { get; set; }
            int[] SourceAmount { get; set}
        }
        struct XfersIn
        {
            string[] TagsIn { get; set; }
            int[] TagsInAmount { get; set; }
        }
        struct XfersOut
        {
            string[] TagsOut { get; set; }
            int[] TagsOutAmount { get; set; }
        }
        int SupportServices { get; set; }
        int FoodImprovments { get; set; }
    }

    public class RevFundOPS
    {
        public string SmartTagOPS { get; set; }
        public string AcctNameOPS { get; set; }
        public struct BudReq 
        {
            public string [] PositionTitle { get; set; }
            public double [] HourlyRate { get; set; }
            public int [] HoursWeek { get; set; }
            public int [] WeeksYear { get; set; }
            public int [] People { get; set; }

        }
    }

    public class Supplemental
    {
        public string SmartTagSupplemental { get; set; }
        public string AcctNameSupplemental { get; set; }
        public int AppBud_Rev { get; set; }
        public int ReqBud_Rev { get; set; }
        public int AppBud_X { get; set; }
        public int ReqBud_X { get; set; }
        public int AppBud_Tot { get; set; }
        public int ReqBud_Tot { get; set; }
        public int AppBud_OPS { get; set; }
        public int ReqBud_OPS { get; set; }
        public int ReqBud_Exp { get; set; }
        public int AppBud_Exp { get; set; }
        public int ReqBud_Xout { get; set; }
        public int AppBud_Xout { get; set; }
        public int ReqBud_OH { get; set; }
        public int AppBud_OH { get; set; }
        public int Revenue { get; set; }

    }


    public class RevenueFundModule : NancyModule
    {
        public RevenueFundModule()
        {
            string page = " ";
            Get["/revenue-fund"] = _ => View["RevenueFund", page];

        }
    }
}