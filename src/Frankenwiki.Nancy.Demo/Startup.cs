using Frankenwiki.Nancy.Demo;
using Frankenwiki.Nancy.Demo.Plumbing;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Nancy.Owin;
using Owin;

[assembly: OwinStartup(typeof (Startup))]

namespace Frankenwiki.Nancy.Demo
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var container = IoC.GetContainer();

            appBuilder.UseNancy(new NancyOptions
            {
                Bootstrapper = new Bootstrapper(container)
            });

            appBuilder.UseStageMarker(PipelineStage.MapHandler);
        }
    }
}