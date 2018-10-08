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
	public class Put_Custom_Validation_Rule_RequestType : INotifyPropertyChanged
	{
		private Custom_Validation_ContextObjectType custom_Validation_Rule_ReferenceField;

		private Custom_Validation_Rule_DataType custom_Validation_Rule_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Custom_Validation_ContextObjectType Custom_Validation_Rule_Reference
		{
			get
			{
				return this.custom_Validation_Rule_ReferenceField;
			}
			set
			{
				this.custom_Validation_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Validation_Rule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Custom_Validation_Rule_DataType Custom_Validation_Rule_Data
		{
			get
			{
				return this.custom_Validation_Rule_DataField;
			}
			set
			{
				this.custom_Validation_Rule_DataField = value;
				this.RaisePropertyChanged("Custom_Validation_Rule_Data");
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
