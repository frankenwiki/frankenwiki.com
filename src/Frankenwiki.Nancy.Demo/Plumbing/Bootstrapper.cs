using System.IO;
using Autofac;
using Frankenwiki.Configuration;
using Nancy;
using Nancy.Bootstrapper;

namespace Frankenwiki.Nancy.Demo.Plumbing
{
    public class Bootstrapper : AutofacNancyBootstrapper
    {
        public Bootstrapper(ILifetimeScope container) : base(container)
        {
        }

        protected override void ApplicationStartup(ILifetimeScope container, IPipelines pipelines)
        {
            var generator = container.Resolve<IFrankengenerator>();
            var store = container.Resolve<IFrankenstore>();
            var rootPathProvider = container.Resolve<IRootPathProvider>();
            var config = container.Resolve<FrankenwikiConfiguration>();
            var sourcePath = Path.Combine(rootPathProvider.GetRootPath(), config.WikiSourcePath);

            generator.GenerateFromSource(sourcePath, store);
        }
    }
}