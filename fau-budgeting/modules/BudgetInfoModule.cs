using Nancy;
using System.Collections.Generic;

namespace fau_budgeting
{
    public class Xin
    {
        public int NumTagsIn;
        public int[] TagsIn = { 750, 240, 100 };
        public int TotalIn;
        public int TagsInSum()
        {
            TotalIn = 0;
            for (int i = 0; i < NumTagsIn; i++)
            {
                TotalIn = TotalIn + TagsIn[i];

            }
            return TotalIn;

        }
    }

    public class Xout
    {
        public  int NumTagsOut;
        public int[] TagsOut;
        public int TotalOut;
        public void TagsInSum()
        {
            TotalOut = 0;
            for(int i=0; i<NumTagsOut; i++)
            {
                TotalOut = TotalOut + TagsOut[i];
            }

        }

    }


    public class BudgetInfo
    {
        public string ClubName;
        public string SmartTag;
        public string AccountName;
        public string Fund;
        public int Overhead;
        public int Net;
        

    }

    public class Expenses
    {
        public Expenses(int a, int b, int c, int d, int e, int f, int g)
        {
            Equipment = a;
            Improvements = b;
            Contingencies = c;
            OfficeResource = d;
            Program = e;
            Services = f;
            Travel = g;
            TotalExpenses = a + b + c + d + e + f + g;
        }
        public int Equipment;
        public int Improvements;
        public int Contingencies;
        public int OfficeResource;
        public int Program;
        public int Services;
        public int Travel;
        public int TotalExpenses;
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

            Xin info2 = new Xin();
            info2.NumTagsIn = 3;
            info2.TotalIn = info2.TagsInSum();
            //.Console.WriteLine("Tags In Sum is " + info2.TotalIn);

            Expenses exp = new Expenses(10, 20, 30, 40, 50, 60, 70);


            Get["/budget-request-info"] = _ => View["budgetinfo", exp];
            //Get["/budget-request-info"] = _ => View["budgetinfo", info2];
            //Get["/budget-request-info"] = _ => View["budgetinfo", info];
        }
    }
}