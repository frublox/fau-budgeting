using Nancy;

namespace fau_budgeting.modules
{
    public class ArchiveModule : NancyModule
    {
        public ArchiveModule()
        {
            Get["/archive"] = _ => View["archive"];
        }
    }
}