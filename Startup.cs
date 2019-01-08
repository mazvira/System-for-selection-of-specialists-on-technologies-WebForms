using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SystemKnowledgeWebForms.Startup))]
namespace SystemKnowledgeWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
