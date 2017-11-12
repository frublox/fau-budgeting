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

            // Example demonstrating iteration
            var data = new List<string>();
            data.Add("green");
            data.Add("blue");
            data.Add("purple");

            Get["/data"] = _ => View["data", data];

            // Example demonstrating capturing
            Get["/{name}"] = parameters => View["name", parameters.name];
        }
    }
}