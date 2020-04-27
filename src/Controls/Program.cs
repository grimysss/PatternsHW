using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//Создаем паттерн Builder
			var containerBuilder = new ContainerBuilder();


			//Создаем для него контейнеры
			containerBuilder
				.RegisterType<ProjectSettings>()
				.AsSelf()
				.SingleInstance();

			containerBuilder
				.RegisterType<MainForm>()
				.AsSelf()
				.SingleInstance();

			//Используем контейнеры
			using(var container = containerBuilder.Build())
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(container.Resolve<MainForm>());
			}
		}
	}
}
