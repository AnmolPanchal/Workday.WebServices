using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Default_Funding_Source_RequestType : INotifyPropertyChanged
	{
		private Default_Funding_SourceObjectType default_Funding_Source_ReferenceField;

		private Default_Funding_Source_DataType default_Funding_Source_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Default_Funding_SourceObjectType Default_Funding_Source_Reference
		{
			get
			{
				return this.default_Funding_Source_ReferenceField;
			}
			set
			{
				this.default_Funding_Source_ReferenceField = value;
				this.RaisePropertyChanged("Default_Funding_Source_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Default_Funding_Source_DataType Default_Funding_Source_Data
		{
			get
			{
				return this.default_Funding_Source_DataField;
			}
			set
			{
				this.default_Funding_Source_DataField = value;
				this.RaisePropertyChanged("Default_Funding_Source_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
