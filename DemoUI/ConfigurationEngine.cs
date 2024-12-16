using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using System.Collections.Specialized;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Memory;
using UseCases.Classes;
using UseCases;
using DataAccessInterface;
using Osmium.Classes;
using DataAccess.Classes;

namespace DemoUI
{
    internal static class ConfigurationEngine
    {
        private static readonly NameValueCollection AppSettings = System.Configuration.ConfigurationManager.AppSettings;
        internal static IContainer Configure()
        {
            var appSettings = new MemoryConfigurationSource
            {
                InitialData = AppSettings.AllKeys.ToDictionary(key => key, key => AppSettings[key])
            };
            var configuration = new Microsoft.Extensions.Configuration.ConfigurationBuilder().Add(appSettings).Build();

            var builder = new ContainerBuilder();
            builder.RegisterInstance<IConfiguration>(configuration);

            //Inject additional dependency below
            builder.RegisterType<DesktopNotification>().As<INotify>();
            builder.RegisterType<TextFileAPI>().As<IFileDataAccess>();
            builder.RegisterType<SqlDataAccess>().As<ISqlDataAccess>();

            //Final dependencies
            builder.RegisterType<Config>().InstancePerLifetimeScope();

            //Inject inital application view
            //builder.RegisterType<MainWindow>();  

            return builder.Build();
        }
    }
}
