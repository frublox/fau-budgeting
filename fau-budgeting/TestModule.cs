using Nancy;

namespace fau_budgeting
{
    public class TestModule : NancyModule
    {
        public TestModule()
        {
            Get["/"] = _ => "Hello!";
        }
    }
}