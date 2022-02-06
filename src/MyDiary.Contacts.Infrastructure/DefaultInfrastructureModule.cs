using Autofac;
using MyDiary.Contacts.Application;
using MyDiary.Contacts.Infrastructure.Data;
using Module = Autofac.Module;

namespace MyDiary.Contacts.Infrastructure
{
    public class DefaultInfrastructureModule : Module
    {
        private bool _isDevelopment = false;

        public DefaultInfrastructureModule(bool isDevelopment)
        {
            _isDevelopment = isDevelopment;
        }

        protected override void Load(ContainerBuilder builder)
        {
            if (_isDevelopment)
            {
                RegisterDevelopmentOnlyDependencies(builder);
            }
            else
            {
                RegisterProductionOnlyDependencies(builder);
            }
            RegisterCommonDependencies(builder);
        }
        private void RegisterCommonDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<ContactRepository>().As<IRepository>()
                .InstancePerLifetimeScope();


        }
        private void RegisterDevelopmentOnlyDependencies(ContainerBuilder builder)
        {
            // TODO: Add development only services
        }
        private void RegisterProductionOnlyDependencies(ContainerBuilder builder)
        {
            // TODO: Add production only services
        }
    }
}
