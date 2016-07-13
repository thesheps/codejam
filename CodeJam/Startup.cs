using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CodeJam.Startup))]
namespace CodeJam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}