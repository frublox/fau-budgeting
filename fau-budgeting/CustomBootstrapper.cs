using Nancy;
using Nancy.Conventions;
using Nancy.Diagnostics;

namespace fau_budgeting
{
    public class CustomBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);

            conventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("/", "content/")
            );
        }

        protected override DiagnosticsConfiguration DiagnosticsConfiguration
        {
            get
            {
                var d = base.DiagnosticsConfiguration;
                d.Password = "password";
                return d;
            }
        }
    }
}