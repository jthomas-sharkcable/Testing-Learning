using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testing_Learning.Startup))]
namespace Testing_Learning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
