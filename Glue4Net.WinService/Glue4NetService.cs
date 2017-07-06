using Glue4Net.Factory;
using System;
using System.ComponentModel;
using System.ServiceProcess;
namespace Glue4Net.WinService
{
	public class Glue4NetService : ServiceBase
	{
		private IContainer components;
		private DomainContainer mContainer;
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.components = new Container();
			base.ServiceName = "Service1";
		}
		public Glue4NetService()
		{
			this.InitializeComponent();
		}
		protected override void OnStart(string[] args)
		{
			Log4NetEventLogImpl log4NetEventLogImpl = new Log4NetEventLogImpl();
			log4NetEventLogImpl.Info("Glue4Net Server Copyright @ henryfan 2014 Version " + typeof(Glue4NetService).Assembly.GetName().Version);
			log4NetEventLogImpl.Info("Website:http://www.ikende.com");
			log4NetEventLogImpl.Info("Email:henryfan@msn.com");
			this.mContainer = new DomainContainer();
			this.mContainer.Log = new Log4NetEventLogImpl();
			this.mContainer.LoadConfig("containerSection");
			this.mContainer.Open();
		}
		protected override void OnStop()
		{
			if (this.mContainer != null)
			{
				this.mContainer.Dispose();
			}
		}
	}
}
