[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BackendVeterinaria.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(BackendVeterinaria.Web.App_Start.NinjectWebCommon), "Stop")]

namespace BackendVeterinaria.Web.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using BackendVeterinaria.Core.Repositories;
    using BackendVeterinaria.Core.Services;
    using BackendVeterinaria.Services;
    using BackendVeterinaria.SQL;
    using BackendVeterinaria.SQL.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                //GlobalConfiguration.Configuration.DependencyResolver = new Ninject.Web.WebApi.NinjectDependencyResolver(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<VeterinariaContext>().ToSelf().InRequestScope();

            //repositorios
            kernel.Bind<IClienteRepository>().To<ClienteRepository>().InRequestScope();
            //servicios
            kernel.Bind<IClienteService>().To<ClienteService>().InRequestScope();

            //repositorios
            kernel.Bind<IMascotaRepository>().To<MascotaRepository>().InRequestScope();
            //servicios
            kernel.Bind<IMascotaService>().To<MascotaService>().InRequestScope();

            //repositorios
            kernel.Bind<ICitaRepository>().To<CitaRepository>().InRequestScope();
            //servicios
            kernel.Bind<ICitaService>().To<CitaService>().InRequestScope();

            //repositorios
            kernel.Bind<IFacturaRepository>().To<FacturaRepository>().InRequestScope();
            //servicios
            kernel.Bind<IFacturaService>().To<FacturaService>().InRequestScope();

            //repositorios
            kernel.Bind<IUsuarioRepository>().To<UsuarioRepository>().InRequestScope();
            //servicios
            kernel.Bind<IUsuarioService>().To<UsuarioService>().InRequestScope();

            kernel.Bind<IConsultaService>().To<ConsultaService>().InRequestScope();
            kernel.Bind<IEmpleadoRepository>().To<EmpleadoRepository>().InRequestScope();

        }
    }
}