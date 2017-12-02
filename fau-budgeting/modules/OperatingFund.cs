using Nancy;
using Nancy.ModelBinding;
using System.Web.Script.Serialization;



namespace fau_budgeting
{
    public class Operating_Request
    {
        public string smarttag { get; set; }
        public string accountname { get; set; }
        public string title { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public int salaries { get; set; }
        public int services { get; set; }
        public int ops_ga { get; set; }
        public int expenses { get; set; }
        public int transfersout { get; set; }
        public int overhead { get; set; }
        public int total { get; set; }

        public string smarttag_sal { get; set; }
        public string accountname_sal { get; set; }
        public string pnumber1 { get; set; }
        public string ptitle1 { get; set; }
        public string fte1 { get; set; }
        public string annualrate1 { get; set; }

        public string pnumber2 { get; set; }
        public string ptitle2 { get; set; }
        public string fte2 { get; set; }
        public string annualrate2 { get; set; }

        public string pnumber3 { get; set; }
        public string ptitle3 { get; set; }
        public string fte3 { get; set; }
        public string annualrate3 { get; set; }

        public string pnumber4 { get; set; }
        public string ptitle4 { get; set; }
        public string fte4 { get; set; }
        public string annualrate4 { get; set; }

        public string pnumber5 { get; set; }
        public string ptitle5 { get; set; }
        public string fte5 { get; set; }
        public string annualrate5 { get; set; }

        public string pnumber6 { get; set; }
        public string ptitle6 { get; set; }
        public string fte6 { get; set; }
        public string annualrate6 { get; set; }

        public string pnumber7 { get; set; }
        public string fte7 { get; set; }

        public string pnumber8 { get; set; }
        public string ptitle7 { get; set; }
        public string fte8 { get; set; }
        public string annualrate7 { get; set; }

        public string pnumber9 { get; set; }
        public string ptitle8 { get; set; }
        public string fte9 { get; set; }
        public string annualrate8 { get; set; }

        public string pnumber10 { get; set; }
        public string ptitle9 { get; set; }
        public string fte10 { get; set; }
        public string annualrate9 { get; set; }

        public string pnumber11 { get; set; }
        public string ptitle10 { get; set; }
        public string fte11 { get; set; }
        public string annualrate10 { get; set; }

        public string pnumber12 { get; set; }
        public string ptitle11 { get; set; }
        public string fte12 { get; set; }
        public string annualrate11 { get; set; }

        public string pnumber13 { get; set; }
        public string ptitle12 { get; set; }
        public string fte13 { get; set; }
        public string annualrate12 { get; set; }

        public string pnumber14 { get; set; }
        public string fte14 { get; set; }

        public int totalsalaries { get; set; }

        public string smarttag_OPS { get; set; }
        public string accountname_OPS { get; set; }
        public string ptitle1_OPS { get; set; }
        public string other1 { get; set; }
        public int hrate1 { get; set; }
        public int hours1 { get; set; }
        public int weeks1 { get; set; }
        public int people1 { get; set; }

        public string ptitle2_OPS { get; set; }
        public string other2 { get; set; }
        public int hrate2 { get; set; }
        public int hours2 { get; set; }
        public int weeks2 { get; set; }
        public int people2 { get; set; }

        public string ptitle3_OPS { get; set; }
        public string other3 { get; set; }
        public int hrate3 { get; set; }
        public int hours3 { get; set; }
        public int weeks3 { get; set; }
        public int people3 { get; set; }

        public string ptitle4_OPS { get; set; }
        public string other4 { get; set; }
        public int hrate4 { get; set; }
        public int hours4 { get; set; }
        public int people4 { get; set; }

        public string ptitle5_OPS { get; set; }
        public string other5 { get; set; }
        public int hrate5 { get; set; }
        public int hours5 { get; set; }
        public int weeks5 { get; set; }
        public int people5 { get; set; }

        public string ptitle6_OPS { get; set; }
        public string other6 { get; set; }
        public int hrate6 { get; set; }
        public int hours6 { get; set; }
        public int weeks6 { get; set; }
        public int people6 { get; set; }

        public string ptitle7_OPS { get; set; }
        public string other7 { get; set; }
        public int hrate7 { get; set; }
        public int hours7 { get; set; }
        public int weeks7 { get; set; }
        public int people7 { get; set; }

        public string ptitle8_OPS { get; set; }
        public string other8 { get; set; }
        public int hrate8 { get; set; }
        public int hours8 { get; set; }
        public int weeks8 { get; set; }
        public int people8 { get; set; }

        public string ptitle9_OPS { get; set; }
        public string other9 { get; set; }
        public int hrate9 { get; set; }
        public int hours9 { get; set; }
        public int weeks9 { get; set; }
        public int people9 { get; set; }

        public string ptitle10_OPS { get; set; }
        public string other10 { get; set; }
        public int hrate10 { get; set; }
        public int hours10 { get; set; }
        public int weeks10 { get; set; }
        public int people10 { get; set; }

        public string ptitle11_OPS { get; set; }
        public string other11 { get; set; }
        public int hrate11 { get; set; }
        public int hours11 { get; set; }
        public int weeks11 { get; set; }
        public int people11 { get; set; }

        public string ptitle12_OPS { get; set; }
        public string other12 { get; set; }
        public int hrate12 { get; set; }
        public int hours12 { get; set; }
        public int weeks12 { get; set; }
        public int people12 { get; set; }

        public string ptitle13_OPS { get; set; }
        public string other13 { get; set; }
        public int hrate13 { get; set; }
        public int hours13 { get; set; }
        public int weeks13 { get; set; }
        public int people13 { get; set; }

        public string ptitle14_OPS { get; set; }
        public string other14 { get; set; }
        public int hrate14 { get; set; }
        public int hours14 { get; set; }
        public int weeks14 { get; set; }
        public int people14 { get; set; }

        public string smarttag_GA { get; set; }
        public string accountname_GA { get; set; }

        public string ptitle1_GA { get; set; }
        public  int hrate15 { get; set; }
        public int hours15 { get; set; }
        public int weeks15 { get; set; }

        public string ptitle16_GA { get; set; }
        public int hrate16 { get; set; }
        public int hours16 { get; set; }
        public int weeks16 { get; set; }

        public string ptitle17_GA { get; set; }
        public int hrate17 { get; set; }
        public int hours17 { get; set; }
        public int weeks17 { get; set; }
        public string ptitle18_GA { get; set; }
        public int hrate18 { get; set; }
        public int hours18 { get; set; }
        public int weeks18 { get; set; }
        public string ptitle19_GA { get; set; }
        public int hrate19 { get; set; }
        public int hours19 { get; set; }
        public int weeks19 { get; set; }
        public string ptitle20_GA { get; set; }
        public int hrate20 { get; set; }
        public int hours20 { get; set; }
        public int weeks20 { get; set; }
        public string ptitle21_GA { get; set; }
        public int hrate21 { get; set; }
        public int hours21 { get; set; }
        public int weeks21 { get; set; }
        public string ptitle22_GA { get; set; }
        public int hrate22 { get; set; }
        public int hours22 { get; set; }
        public int weeks22 { get; set; }
        public string ptitle23_GA { get; set; }
        public int hrate23 { get; set; }
        public int hours23 { get; set; }
        public int weeks23 { get; set; }
        public string ptitle24_GA { get; set; }
        public int hrate24 { get; set; }
        public int hours24 { get; set; }
        public int weeks24 { get; set; }
        public string ptitle25_GA { get; set; }
        public int hrate25 { get; set; }
        public int hours25 { get; set; }
        public int weeks25 { get; set; }
        public string ptitle26_GA { get; set; }
        public int hrate26 { get; set; }
        public int hours26 { get; set; }
        public int weeks26 { get; set; }
        public string ptitle27_GA { get; set; }
        public int hrate27 { get; set; }
        public int hours27 { get; set; }
        public int weeks27 { get; set; }
        public string ptitle28_GA { get; set; }
        public int hrate28 { get; set; }
        public int hours28 { get; set; }
        public int weeks28 { get; set; }
        public string smarttag_EXP { get; set; }
        public string accountname_EXP { get; set; }
        public string support { get; set; }
        public string food { get; set; }
        public string programs { get; set; }
        public string travel { get; set; }

        public string descr1 { get; set; }
        public int budget1 { get; set; }
        public string descr2 { get; set; }
        public int budget2 { get; set; }
        public string descr3 { get; set; }
        public int budget3 { get; set; }
        public string descr4 { get; set; }
        public int budget4 { get; set; }
        public string descr5 { get; set; }
        public int budget5 { get; set; }
        public string transout1 { get; set; }
        public int transout2 { get; set; }
        public string transout3 { get; set; }
        public int transout4 { get; set; }
        public string transout5 { get; set; }
        public int transout6 { get; set; }
        public string ops_justification { get; set; }
        public string ops_ga_justification { get; set; }
        public string support_justification { get; set; }
        public string food_justification { get; set; }
        public string programs_justification { get; set; }
        public string travel_justification { get; set; }
        public string other_justification { get; set; }
        public string transout_justification { get; set; }








    }

    public class OperatingFund : NancyModule
    {
        public OperatingFund()
        {

            Get["/operating-fund"] = _ => View["OperatingFund"];

            Post["/operating-fund-submit"] = _ =>
            {
                Operating_Request request = this.Bind<Operating_Request>();
                var json = new JavaScriptSerializer().Serialize(request);

                return View["OperatingFund"];
            };


        }
    }

}