using Nancy;
using Nancy.ModelBinding;
using System.Web.Script.Serialization;



namespace fau_budgeting
{
    public class Reserve_Request
    {
        public string smarttag { get; set; }
        public string accountname { get; set; }
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


    }




    public class ReserveFund : NancyModule
    {
        public ReserveFund()
        {

                     

            Get["/reserve-fund"] = _ => View["ReserveFund"];

            Post["/reserve-fund-submit"] = _ =>
            {
                Reserve_Request input = this.Bind<Reserve_Request>();

                var json = new JavaScriptSerializer().Serialize(input);
                //var jsonStr = JSON.stringify(jsonVar);

                return View["ReserveFund"];
            };

            

        }
    }
}