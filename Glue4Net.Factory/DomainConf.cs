using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
namespace Glue4Net.Factory
{
	public class DomainConf : ConfigurationElement
	{
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string NamePropertyName = "name";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string PathPropertyName = "path";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string UpdateWatchPropertyName = "updateWatch";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string CompilerPropertyName = "compiler";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string WatchFilterPropertyName = "watchFilter";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The Name."), ConfigurationProperty("name", IsRequired = true, IsKey = true, IsDefaultCollection = false)]
		public virtual string Name
		{
			get
			{
				return (string)base["name"];
			}
			set
			{
				base["name"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The Path."), ConfigurationProperty("path", IsRequired = true, IsKey = false, IsDefaultCollection = false)]
		public virtual string Path
		{
			get
			{
				return (string)base["path"];
			}
			set
			{
				base["path"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The UpdateWatch."), ConfigurationProperty("updateWatch", IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = true)]
		public virtual bool UpdateWatch
		{
			get
			{
				return (bool)base["updateWatch"];
			}
			set
			{
				base["updateWatch"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The Compiler."), ConfigurationProperty("compiler", IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = true)]
		public virtual bool Compiler
		{
			get
			{
				return (bool)base["compiler"];
			}
			set
			{
				base["compiler"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The WatchFilter."), ConfigurationProperty("watchFilter", IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = "*.dll|*.xml|*.config")]
		public virtual string WatchFilter
		{
			get
			{
				return (string)base["watchFilter"];
			}
			set
			{
				base["watchFilter"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override bool IsReadOnly()
		{
			return false;
		}
	}
}
