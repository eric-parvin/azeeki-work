using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ValidateMyInsurance.Startup))]

namespace ValidateMyInsurance
{
    public partial class Startup 
    {
        // OWIN startup disabled in web.config
        // This class is kept for compatibility but not used
    }
}
