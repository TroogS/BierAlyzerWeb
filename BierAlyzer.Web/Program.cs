using System;
using System.Linq;
using BierAlyzer.Contracts.Model;
using BierAlyzer.EntityModel;
using BierAlyzer.Web.Helper;
using BierAlyzerWeb;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BierAlyzer.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = ContextHelper.OpenContext())
            {
                #region EnsureAdmin

                var defaultAdminMail = "bier@troogs.de";

                var adminUser = context.User.FirstOrDefault(u => u.Mail.ToLower() == defaultAdminMail);
                if (adminUser == null)
                {
                    var user = new User
                    {
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                        Enabled = true,
                        Hash = "B1B57C0699ED6120AA594127C84DB895",
                        Salt = "71BFDCDED04E94A8939E20A0DB8B174D",
                        Mail = defaultAdminMail,
                        Type = UserType.Admin,
                        Username = "Admin",
                        Origin = "Uni Siegen"
                    };

                    context.User.Add(user);
                }
                else
                {
                    adminUser.Type = UserType.Admin;
                }

                context.SaveChanges();

                #endregion
            }

            var host = CreateHostBuilder(args).Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}