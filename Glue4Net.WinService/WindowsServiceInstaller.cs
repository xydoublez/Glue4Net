using System;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;
using System.Xml;
namespace Glue4Net.WinService
{
	[RunInstaller(true)]
	public class WindowsServiceInstaller : Installer
	{
		public WindowsServiceInstaller()
		{
			ServiceProcessInstaller serviceProcessInstaller = new ServiceProcessInstaller();
			ServiceInstaller serviceInstaller = new ServiceInstaller();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(Path.GetDirectoryName(typeof(WindowsServiceInstaller).Assembly.Location) + Path.DirectorySeparatorChar + "Glue4Net.WinService.exe.config");
			XmlNode xmlNode = xmlDocument.LastChild["containerSection"];
			serviceProcessInstaller.Account = ServiceAccount.LocalSystem;
			serviceProcessInstaller.Username = null;
			serviceProcessInstaller.Password = null;
			serviceInstaller.DisplayName = xmlNode.Attributes["displayName"].Value;
			serviceInstaller.StartType = ServiceStartMode.Automatic;
			serviceInstaller.ServiceName = xmlNode.Attributes["serviceName"].Value;
			base.Installers.Add(serviceProcessInstaller);
			base.Installers.Add(serviceInstaller);
		}
	}
}
