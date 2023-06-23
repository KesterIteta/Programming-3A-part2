using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prog7311_part2_solution.Startup))]
namespace prog7311_part2_solution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
