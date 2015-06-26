using Autofac;
using Frankenwiki;
using Frankenwiki.Configuration;

namespace FrankenwikiDotCom.Plumbing
{
    public class WebAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(_ => FrankenwikiConfiguration.Create()
                .WithWikiSourcePath("my-wiki")
                .Build());
            builder
                .RegisterType<Frankengenerator>()
                .As<IFrankengenerator>();
            builder
                .RegisterType<InMemoryFrankenstore>()
                .As<IFrankenstore>()
                .SingleInstance();
            builder
                .RegisterType<InMemoryFrankensearch>()
                .As<IFrankensearch>()
                .SingleInstance();
        }
    }
}