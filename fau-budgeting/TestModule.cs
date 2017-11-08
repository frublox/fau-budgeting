using Nancy;

namespace fau_budgeting
{
    public class TestModule : NancyModule
    {
        public TestModule()
        {
            Get["/"] = _ => "hi!";
            Get["/{name}"] = parameters => View["test", parameters.name];
        }
    }
}