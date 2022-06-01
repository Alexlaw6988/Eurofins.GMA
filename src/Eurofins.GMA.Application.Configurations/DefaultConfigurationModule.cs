using Autofac;
using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Eurofins.GMA.Application.Implementations;
using Eurofins.GMA.Domain.Implementations;
using Eurofins.GMA.Domain.Interfaces;
using Eurofins.GMA.Domain.Interfaces.Managers;
using Eurofins.GMA.Domain.Repositories;
using Eurofins.GMA.Infrastructure.Data.Repositories;
using System.Reflection;
using Module = Autofac.Module;

namespace Eurofins.GMA.Application.Configurations
{
    public class DefaultConfigurationModule : Module
    {
        private readonly bool _isDevelopment = false;
        private readonly List<Assembly> _assemblies = new();

        public DefaultConfigurationModule(bool isDevelopment, Assembly? callingAssembly = null)
        {
            _isDevelopment = isDevelopment;
            var infrastructureAssembly = Assembly.GetAssembly(typeof(StartupSetup));

            if (infrastructureAssembly != null)
            {
                _assemblies.Add(infrastructureAssembly);
            }
            if (callingAssembly != null)
            {
                _assemblies.Add(callingAssembly);
            }
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

        private static void RegisterCommonDependencies(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<>))
                .As(typeof(IRepository<>))
                .InstancePerLifetimeScope();

            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SalaryRepository>().As<ISalaryRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserRepository>().As<IUserRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AssetManager>().As<IAssetManager>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DepartmentManager>().As<IDepartmentManager>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SalaryManager>().As<ISalaryManager>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserManager>().As<IUserManager>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AssetService>().As<IAssetService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DepartmentService>().As<IDepartmentService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SalaryService>().As<ISalaryService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserService>().As<IUserService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<GuidService>().As<IGuidService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CsvService<AssetDto>>().As<ICsvService<AssetDto>>()
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(CsvService<>))
                .As(typeof(ICsvService<>))
                .InstancePerLifetimeScope();
        }

        private static void RegisterDevelopmentOnlyDependencies(ContainerBuilder builder)
        {
            // TODO: Add development only services         


        }

        private static void RegisterProductionOnlyDependencies(ContainerBuilder builder)
        {
            // TODO: Add production only services
        }

    }
}
