using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DataAccess>().As<IDataAccess>();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<SystemMessaging>().As<ISystemMessaging>();
            builder.RegisterType<CheckUser>().As<ICheckUser>();
            builder.RegisterType<MainMenuOptions>().As<IMainMenuOptions>();
            builder.RegisterType<QueryString>().As<IQueryString>();
            builder.RegisterType<MySQLConnection>().As<IMySQLConnection>();
            builder.RegisterType<RetrieveUserInput>().As<IRetrieveUserInput>();
            builder.RegisterType<CheckUser>().As<ICheckUser>();
            builder.RegisterType<CheckPin>().As<ICheckPin>();
            builder.RegisterType<RetrieveUserInfo>().As<IRetrieveUserInfo>();
            builder.RegisterType<MainMenu>().As<IMainMenu>();
            builder.RegisterType<MainMenuOptions>().As<IMainMenuOptions>();
            builder.RegisterType<MainMenuOptionsMessaging>().As<IMainMenuOptionsMessaging>();
            builder.RegisterType<RetrieveUserMainMenuInput>().As<IRetrieveUserMainMenuInput>();

            return builder.Build();
        }
    }
}
