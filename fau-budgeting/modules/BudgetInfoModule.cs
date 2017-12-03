using Nancy;
using System.Collections.Generic;

namespace fau_budgeting
{

    public class BudgetInfo
    {
        public string ClubName;
        public string SmartTag;
        public string AccountName;
        public string Fund;
        public int Overhead;
        public int Net;
        public int NumTagsIn;
        public int tagsin1;
        public int tagsin2;
        public int tagsin3;
        public int TotalIn;
        public void Total_In_Calc()
        {
            TotalIn = tagsin1 + tagsin2 + tagsin3;
        }
        
        public int tagsout1;
        public int tagsout2;
        public int tagsout3;
        public int TotalOut;
        public void Total_Out_Calc()
        {
            TotalOut = tagsout1 + tagsout2 + tagsout3;
        }
        public int Equipment;
        public int Improvements;
        public int Contingencies;
        public int OfficeResource;
        public int Program;
        public int Services;
        public int Travel;
        public int TotalExpenses;
        public string comments;
        }

    public class BudgetInfoModule : NancyModule
    {
        public BudgetInfoModule()
        {
            BudgetInfo info = new BudgetInfo
            {
                ClubName = "Robotics Club",
                SmartTag = "Niner55312",
                AccountName = "Robotics Club Council",
                Fund = "Student Government Reserve",
                Overhead = 2500,
                Net = 80000,
                  
             

            };

            Get["/budget-request-info"] = _ => View["budgetinfo", info];
            
        }
    }
}