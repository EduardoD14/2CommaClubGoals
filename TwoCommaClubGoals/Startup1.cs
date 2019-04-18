using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwoCommaClubGoals.Startup))]
namespace TwoCommaClubGoals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
