using Autofac;

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
            builder.RegisterType<RetrieveUserMainMenuInput>().As<IRetrieveUserMainMenuInput>();
            builder.RegisterType<WithdrawMenu>().As<IWithdrawMenu>();
            builder.RegisterType<WithdrawCalculation>().As<IWithdrawCalculation>();
            builder.RegisterType<BalanceUpdate>().As<IBalanceUpdate>();
            builder.RegisterType<RetrieveUserCustomInput>().As<IRetrieveUserCustomInput>();
            builder.RegisterType<UpdateUserInfo>().As<IUpdateUserInfo>();
            builder.RegisterType<RetrieveWithdrawOrDepositOption>().As<IRetrieveWithdrawOrDepositOption>();
            builder.RegisterType<QuitSelectionValidation>().As<IQuitSelectionValidation>();
            builder.RegisterType<DepositMenu>().As<IDepositMenu>();
            builder.RegisterType<DepositCalculation>().As<IDepositCalculation>();
            builder.RegisterType<QuitApplicationHandle>().As<IQuitApplicationHandle>();
            builder.RegisterType<Update>().As<IUpdate>();

            return builder.Build();
        }
    }
}
