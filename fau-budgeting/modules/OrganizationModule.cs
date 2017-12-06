using Nancy;

namespace fau_budgeting.modules
{
    public class OrganizationModule : NancyModule
    {
        public OrganizationModule()
        {
            Get["/organization"] = _ =>
            {
                return View["organization", Database.GetBudgetRequests(1)];
            };
        }
    }
}