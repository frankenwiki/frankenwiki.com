using System.Reflection;
using Autofac;
using Frankenwiki.Host.Nancy.Features;

namespace Frankenwiki.Nancy.Demo.Plumbing
{
    public static class IoC
    {
        public static Assembly[] Assemblies =
        {
            typeof (WebAutofacModule).Assembly,
            typeof (IndexModule).Assembly
        };

        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(Assemblies);

            return builder.Build();
        }
    }
}