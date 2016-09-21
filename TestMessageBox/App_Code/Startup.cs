using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMessageBox.Startup))]
namespace TestMessageBox
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
        }
    }
}
