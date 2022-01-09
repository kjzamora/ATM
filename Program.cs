using Autofac;
using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ATM";
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
