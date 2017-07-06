using System;
using System.CodeDom.Compiler;
using System.Configuration;
namespace Glue4Net.Factory
{
	[ConfigurationCollection(typeof(DomainConf), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap, AddItemName = "add", RemoveItemName = "remove", ClearItemsName = "clear")]
	public class DomainCollection : ConfigurationElementCollection
	{
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		internal const string DomainConfPropertyName = "domainConf";
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.AddRemoveClearMap;
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override string ElementName
		{
			get
			{
				return "domainConf";
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public DomainConf this[int index]
		{
			get
			{
				return (DomainConf)base.BaseGet(index);
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public DomainConf this[object name]
		{
			get
			{
				return (DomainConf)base.BaseGet(name);
			}
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override bool IsElementName(string elementName)
		{
			return elementName == "domainConf";
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((DomainConf)element).Name;
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		protected override ConfigurationElement CreateNewElement()
		{
			return new DomainConf();
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public void Add(DomainConf domainConf)
		{
			base.BaseAdd(domainConf);
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public void Remove(DomainConf domainConf)
		{
			base.BaseRemove(this.GetElementKey(domainConf));
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public DomainConf GetItemAt(int index)
		{
			return (DomainConf)base.BaseGet(index);
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public DomainConf GetItemByKey(string name)
		{
			return (DomainConf)base.BaseGet(name);
		}
		[GeneratedCode("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.0.5")]
		public override bool IsReadOnly()
		{
			return false;
		}
	}
}
