namespace fau_budgeting
{
    public partial class BudgetRequest
    {
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
    }
}