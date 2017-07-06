using log4net;
using log4net.Config;
using System;
namespace Glue4Net.Factory
{
	public class Log4NetEventLogImpl : MarshalByRefObject, IEventLog
	{
		public ILog Log
		{
			get
			{
				return LogManager.GetLogger("Glue4Net");
			}
		}
		public override object InitializeLifetimeService()
		{
			return null;
		}
		static Log4NetEventLogImpl()
		{
			XmlConfigurator.Configure();
		}
		public void Debug(string value)
		{
			this.Log.Debug(value);
		}
		public void Debug(string formater, params object[] data)
		{
			this.Log.DebugFormat(formater, data);
		}
		public void Info(string value)
		{
			this.Log.Info(value);
		}
		public void Info(string formater, params object[] data)
		{
			this.Log.InfoFormat(formater, data);
		}
		public void Error(string value)
		{
			this.Log.Error(value);
		}
		public void Error(string formater, params object[] data)
		{
			this.Log.ErrorFormat(formater, data);
		}
	}
}
