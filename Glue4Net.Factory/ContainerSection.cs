using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
namespace Glue4Net.Factory
{
	public class ContainerSection : ConfigurationSection
	{
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string ContainerSectionSectionName = "containerSection";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string XmlnsPropertyName = "xmlns";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string DisplayNamePropertyName = "displayName";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string ServiceNamePropertyName = "serviceName";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string DomainsPropertyName = "domains";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public static ContainerSection Instance
		{
			get
			{
				return (ContainerSection)ConfigurationManager.GetSection("containerSection");
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), ConfigurationProperty("xmlns", IsRequired = false, IsKey = false, IsDefaultCollection = false)]
		public string Xmlns
		{
			get
			{
				return (string)base["xmlns"];
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The DisplayName."), ConfigurationProperty("displayName", IsRequired = false, IsKey = false, IsDefaultCollection = false)]
		public virtual string DisplayName
		{
			get
			{
				return (string)base["displayName"];
			}
			set
			{
				base["displayName"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The ServiceName."), ConfigurationProperty("serviceName", IsRequired = false, IsKey = false, IsDefaultCollection = false)]
		public virtual string ServiceName
		{
			get
			{
				return (string)base["serviceName"];
			}
			set
			{
				base["serviceName"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5"), Description("The Domains."), ConfigurationProperty("domains", IsRequired = true, IsKey = false, IsDefaultCollection = false)]
		public virtual DomainCollection Domains
		{
			get
			{
				return (DomainCollection)base["domains"];
			}
			set
			{
				base["domains"] = value;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override bool IsReadOnly()
		{
			return false;
		}
	}
}
