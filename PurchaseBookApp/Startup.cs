using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PurchaseBookApp.Models;

[assembly: FunctionsStartup(typeof(PurchaseBookApp.Startup))]
namespace PurchaseBookApp
{
    class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string SqlConnection = "Data Source=CTSDOTNET664;Initial Catalog=DigitalBookManagement;Persist Security Info=True;User ID=sa;Password=pass@word1;";
            builder.Services.AddDbContext<DigitalBookManagementContext>(
                options => options.UseSqlServer(SqlConnection));
        }
    }
}
