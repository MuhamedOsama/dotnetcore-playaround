using Autofac;
using Ensaf.Core.Interfaces;
using Ensaf.Core.Services;

namespace Ensaf.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
