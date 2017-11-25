using Nancy;
using System.Collections.Generic;

namespace fau_budgeting
{
    public class ReserveFundSD
    {
        string SmartTag { get; set; }
        string AcctName { get; set; }
        struct XfersIn
        {
            string[] TagsIn { get; set; }
            int[] TagsInAmount { get; set; }
        }
        int Equipment;
        int Improvments;
        int Contingencies;
        struct XfersOut
        {
            string[] TagsOut { get; set; }
            int[] TagsOutAmount { get; set; }
        }

    }

    public class Supplemental_Form_Reserve
    {
        string SmartTag { get; set; }
        string AcctName { get; set; }
        public int ReqBud_Exp { get; set; }
        public int AppBud_Exp { get; set; }
        public int AppBud_X { get; set; }
        public int ReqBud_X { get; set; }
        public int ReqBud_OH { get; set; }
        public int AppBud_OH { get; set; }
        public int Xin_Amt { get; set; }
        public int EquipmentIn_Amt { get; set; }
        public int Improvements_Amt { get; set; }
        public int Contingencies_Amt { get; set; }
        public int Other_Amt { get; set; }
        public int Xout_Amt { get; set; }


    }


    public class ReserveFund : NancyModule
    {
        public ReserveFund()
        {


            Get["/reserve-fund"] = _ => View["ReserveFund"];
        }
    }
}