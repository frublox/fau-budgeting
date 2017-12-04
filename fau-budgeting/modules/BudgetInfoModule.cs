using Nancy;
using Nancy.ModelBinding;

namespace fau_budgeting
{
    class FormData
    {
        public int Id;
        public string Comments;
        public string RequestType;
    }

    class BudgetInfoData
    {
        public string Route;
        public string ButtonText;

        public BudgetRequest Request;

        public bool IsOrg = false;
        public bool IsAdmin = false;
        public bool ShowButton = true;
        public bool Resubmit = false;

        public string MasterTemplate
        {
            get
            {
                if (IsAdmin) return "master-asab.sshtml";
                else return "master-org.sshtml";
            }
        }
    }

    public class BudgetInfoModule : NancyModule
    {
        public BudgetInfoModule() : base("/budget-request-info")
        {
            Get["/admin"] = _ => 
            {
                int id = Request.Query["id"];
                BudgetRequest request = Database.GetBudgetRequest(id);
                string requestType = request?.RequestType;

                var data = new BudgetInfoData
                {
                    Request = request
                };

                data.IsAdmin = true;

                if (request.Status == "New")
                {
                    data.Route = "accept";
                    data.ButtonText = "Accept";
                }
                else if (request.Status == "Accepted")
                {
                    data.Route = "approve";
                    data.ButtonText = "Approve";
                }
                else if (request.Status == "Approved" || request.Status == "Awaiting Resubmission")
                {
                    data.ShowButton = false;
                }

                if (requestType == "Revenue Fund")
                {
                    
                    return View["budget-info/budget-info-revenue", data];
                }
                else if (requestType == "Reserve Fund")
                {
                    return View["budget-info/budget-info-reserve", data];
                }
                else if (requestType == "Operating Fund")
                {
                    return View["budget-info/budget-info-operating", data];
                }
                else
                {
                    return "Budget request was not found.";
                }
            };

            Get["/organization"] = _ =>
            {
                int id = Request.Query["id"];
                BudgetRequest request = Database.GetBudgetRequest(id);
                string requestType = request?.RequestType;

                var data = new BudgetInfoData
                {
                    Request = request
                };

                data.IsOrg = true;
                data.ShowButton = false;

                if (request.Status == "Awaiting Resubmission")
                {
                    data.Resubmit = true;
                }

                if (requestType == "Revenue Fund")
                {
                    return View["budget-info/budget-info-revenue", data];
                }
                else if (requestType == "Reserve Fund")
                {
                    return View["budget-info/budget-info-reserve", data];
                }
                else if (requestType == "Operating Fund")
                {
                    return View["budget-info/budget-info-operating", data];
                }
                else
                {
                    return "Budget request was not found.";
                }
            };

            Post["/accept"] = _ =>
            {
                var data = this.Bind<FormData>();

                Database.AcceptBudgetRequest(data.Id);

                return Response.AsRedirect("/admin");
            };

            Post["/edit"] = _ =>
            {
                var data = this.Bind<FormData>();

                if (data.RequestType == "Revenue Fund")
                {
                    return Response.AsRedirect("/revenue-fund?id=" + data.Id);
                }
                else if (data.RequestType == "Reserve Fund")
                {
                    return Response.AsRedirect("/reserve-fund?id=" + data.Id);
                }
                else if (data.RequestType == "Operating Fund")
                {
                    return Response.AsRedirect("/operating-fund?id=" + data.Id);
                }
                else
                {
                    return "Invalid request type";
                }
            };
            
            Post["/send-back"] = _ =>
            {
                var data = this.Bind<FormData>();

                Database.SendBackBudgetRequest(data.Id, data.Comments);

                return Response.AsRedirect("/admin");
            };
        }
    }
}