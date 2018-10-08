using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Engagement_External_Item_RequestType : INotifyPropertyChanged
	{
		private Engagement_External_ItemObjectType engagement_External_Item_ReferenceField;

		private Engagement_External_Item_DataType engagement_External_Item_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Engagement_External_ItemObjectType Engagement_External_Item_Reference
		{
			get
			{
				return this.engagement_External_Item_ReferenceField;
			}
			set
			{
				this.engagement_External_Item_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_External_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Engagement_External_Item_DataType Engagement_External_Item_Data
		{
			get
			{
				return this.engagement_External_Item_DataField;
			}
			set
			{
				this.engagement_External_Item_DataField = value;
				this.RaisePropertyChanged("Engagement_External_Item_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
