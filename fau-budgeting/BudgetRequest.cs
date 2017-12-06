using Newtonsoft.Json.Linq;

namespace fau_budgeting
{
    public partial class BudgetRequest
    {
        public JObject GetRequestDataAsJson()
        {
            return JObject.Parse(RequestData);
        }

        public HtmlProps Html
        {
            get
            {
                switch (Status)
                {
                    case "New": return new HtmlProps { Class = "status-new" };
                    case "Accepted": return new HtmlProps { Class = "status-accepted" };
                    case "Approved": return new HtmlProps { Class = "status-approved" };
                    case "Awaiting Resubmission": return new HtmlProps { Class = "status-awaiting" };
                    default: return null;
                }
            }
        }

        public string StatusText
        {
            get
            {
                if (Status == "New")
                {
                    return "Pending";
                }
                else
                {
                    return Status;
                }
            }
        }
    }
}