using System;
using System.ServiceProcess;
namespace Glue4Net.WinService
{
	internal static class Program
	{
		private static void Main()
		{
			ServiceBase[] services = new ServiceBase[]
			{
				new Glue4NetService()
			};
			ServiceBase.Run(services);
		}
	}
}
