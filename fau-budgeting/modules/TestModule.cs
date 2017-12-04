using Nancy;
using System.Collections.Generic;

namespace fau_budgeting
{
    public class TestModule : NancyModule
    {
        public TestModule()
        {
            // Simple example that returns a string
            Get["/"] = _ => "hi!";

            Get["/nav-bar"] = _ => View["/navigation/nav-asab"];
        }
    }
}