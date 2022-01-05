using System;
using System.Collections.Generic;
using ATM.Models;
using MySql.Data.MySqlClient;
using Dapper;
using System.Threading.Tasks;
using Autofac;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
