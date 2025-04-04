using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSWT.src.core;
using CSWT.src.core.db;
using CSWT.src.core.form;
using Microsoft.Extensions.DependencyInjection;

namespace CSWT
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            var assembly = Assembly.GetExecutingAssembly();

            assembly.GetTypes()
                .Where(t => t.Name.EndsWith("Model") && !t.IsAbstract)
                .ToList()
                .ForEach(type => services.AddSingleton(type));

            assembly.GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsAbstract)
                .ToList()
                .ForEach(type => services.AddSingleton(type));

            assembly.GetTypes()
                .Where(t => t.Name.EndsWith("Controller") && !t.IsAbstract)
                .ToList()
                .ForEach(type => services.AddTransient(type));

            assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Form)) && !t.IsAbstract)
                .ToList()
                .ForEach(type => services.AddTransient(type));

            services.AddSingleton<FormManager>();
            services.AddSingleton<DatabaseRepository>();
            services.AddSingleton<UserContext>();
            services.AddSingleton<FormContext>();
            services.AddScoped<SessionContext>();

            var provider = services.BuildServiceProvider();
            var formManager = provider.GetRequiredService<FormManager>();
            var homeForm = provider.GetRequiredService<HomeForm>();
            formManager.SetMainForm(homeForm);

            Application.Run(homeForm);
        }
    }
}
