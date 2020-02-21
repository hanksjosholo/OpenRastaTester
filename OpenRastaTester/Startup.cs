using System;
using System.Threading.Tasks;
using Microsoft.Owin;

using OpenRasta.Hosting.Katana;
using Owin;



[assembly: OwinStartup(typeof(OpenRastaTester.Startup))]

namespace OpenRastaTester
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configSources = new Configuration();
            app.UseOpenRasta(configSources);

        }
    }
}
