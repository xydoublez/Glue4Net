using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
namespace Glue4Net.Factory
{
	public class DomainContainer : IDisposable
	{
		private FileWatcher mFileWatcher;
		private string mSectionName;
		private List<DomainAdapter> mDomains = new List<DomainAdapter>();
		public IEventLog Log
		{
			get;
			set;
		}
		private ContainerSection GetConfigSection()
		{
			ContainerSection result = null;
			try
			{
				Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap
				{
					ExeConfigFilename = AppDomain.CurrentDomain.BaseDirectory + "domains.config"
				}, ConfigurationUserLevel.None);
				result = (ContainerSection)configuration.GetSection(this.mSectionName);
			}
			catch (Exception ex)
			{
				if (this.Log != null)
				{
					this.Log.Error("load domains config error {1}!", new object[]
					{
						ex.Message
					});
				}
			}
			return result;
		}
		public void LoadConfig(string config = "containerSection")
		{
			this.mSectionName = config;
			string pattern = "^([^\\\\]+)$";
			ContainerSection configSection = this.GetConfigSection();
			if (configSection != null)
			{
				foreach (DomainConf domainConf in configSection.Domains)
				{
					string text = domainConf.Path;
					if (Regex.IsMatch(text, pattern))
					{
						text = AppDomain.CurrentDomain.BaseDirectory + text;
					}
					if (!Directory.Exists(text))
					{
						if (this.Log != null)
						{
							this.Log.Error("<{1}> domain {0} path notfound!", new object[]
							{
								text,
								domainConf.Name
							});
						}
					}
					else
					{
						DomainAdapter domainAdapter = this.AddDomain(domainConf.Name, text, domainConf.UpdateWatch, domainConf.WatchFilter.Split(new char[]
						{
							'|'
						}), domainConf.Compiler);
						domainAdapter["config"] = domainConf;
					}
				}
			}
		}
		public DomainAdapter AddDomain(string name, string path, bool updateWatch, string[] filter, bool compiler)
		{
			DomainAdapter domainAdapter = new DomainAdapter(path, name, new DomainArgs
			{
				Compiler = compiler,
				WatchFilter = filter,
				UpdateWatch = updateWatch
			});
			this.mDomains.Add(domainAdapter);
			return domainAdapter;
		}
		public void Reload()
		{
			if (this.Log != null)
			{
				this.Log.Info("reload domain container ...");
			}
			string pattern = "^([^\\\\]+)$";
			ContainerSection configSection = this.GetConfigSection();
			if (configSection != null)
			{
				IEnumerator enumerator = configSection.Domains.GetEnumerator();
				try
				{
					DomainConf conf;
					while (enumerator.MoveNext())
					{
						conf = (DomainConf)enumerator.Current;
						string text = conf.Path;
						if (Regex.IsMatch(text, pattern))
						{
							text = AppDomain.CurrentDomain.BaseDirectory + text;
						}
						DomainAdapter domainAdapter = this.mDomains.Find((DomainAdapter i) => i.AppName == conf.Name);
						if (domainAdapter != null)
						{
							DomainConf domainConf = (DomainConf)domainAdapter["config"];
							if (conf.Path != domainConf.Path || conf.Compiler != domainConf.Compiler || conf.UpdateWatch != domainConf.UpdateWatch || conf.WatchFilter != domainConf.WatchFilter)
							{
								domainAdapter.UnLoad();
								this.mDomains.Remove(domainAdapter);
								domainAdapter = null;
							}
						}
						if (!Directory.Exists(text))
						{
							if (this.Log != null)
							{
								this.Log.Error("<{1}> domain {0} path notfound!", new object[]
								{
									text,
									conf.Name
								});
							}
						}
						else
						{
							if (domainAdapter == null)
							{
								if (this.Log != null)
								{
									this.Log.Info("load <{0}> domain.", new object[]
									{
										conf.Name
									});
								}
								domainAdapter = this.AddDomain(conf.Name, text, conf.UpdateWatch, conf.WatchFilter.Split(new char[]
								{
									'|'
								}), conf.Compiler);
								domainAdapter.Log = this.Log;
								domainAdapter.Load();
								domainAdapter["config"] = conf;
							}
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
		public void Open()
		{
			this.mFileWatcher = new FileWatcher(AppDomain.CurrentDomain.BaseDirectory, new string[]
			{
				"domains.config"
			});
			this.mFileWatcher.Change += delegate(FileWatcher e)
			{
				this.Reload();
			};
			foreach (DomainAdapter current in this.mDomains)
			{
				current.Log = this.Log;
				current.Load();
			}
		}
		public void Dispose()
		{
			foreach (DomainAdapter current in this.mDomains)
			{
				current.UnLoad();
			}
		}
	}
}
