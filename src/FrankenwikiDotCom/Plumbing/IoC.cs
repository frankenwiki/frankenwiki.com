using System.Reflection;
using Autofac;
using Frankenwiki.Host.Nancy.Features;

namespace FrankenwikiDotCom.Plumbing
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