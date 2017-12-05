using Nancy;
using Nancy.Linker;
using Nancy.ModelBinding;

namespace fau_budgeting.modules
{
    class LoginFormData
    {
        public string Email;
        public string Password;
        public bool Remember;
    }

    class LoginResponseData
    {
        public string ErrorMessage;
        public bool HasErrors;
    }

    public class LoginModule : NancyModule
    {
        public LoginModule(IResourceLinker linker)
        {
            Get["/"] = _ => View["login"];

            Post["/login"] = _ =>
            {
                LoginFormData data = this.Bind<LoginFormData>();
                User user = Database.GetUser(data.Email);

                var responseData = new LoginResponseData
                {
                    HasErrors = true,
                    ErrorMessage = "Invalid login credentials"
                };

                var invalidLoginView = View["login", responseData];

                if (user == null)
                {
                    return invalidLoginView;
                }

                if (user.Type == "ASAB")
                {
                    return Response.AsRedirect("/admin");
                }
                else if (user.Type == "Organization")
                {
                    return Response.AsRedirect("/organization");
                }
                else
                {
                    return invalidLoginView;
                }
            };
        }
    }
}