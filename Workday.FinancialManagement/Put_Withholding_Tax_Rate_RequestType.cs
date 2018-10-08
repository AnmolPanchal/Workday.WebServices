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
	public class Put_Withholding_Tax_Rate_RequestType : INotifyPropertyChanged
	{
		private Tax_RateObjectType withholding_Tax_Rate_ReferenceField;

		private Withholding_Tax_Rate_DataType withholding_Tax_Rate_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tax_RateObjectType Withholding_Tax_Rate_Reference
		{
			get
			{
				return this.withholding_Tax_Rate_ReferenceField;
			}
			set
			{
				this.withholding_Tax_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Tax_Rate_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Withholding_Tax_Rate_DataType Withholding_Tax_Rate_Data
		{
			get
			{
				return this.withholding_Tax_Rate_DataField;
			}
			set
			{
				this.withholding_Tax_Rate_DataField = value;
				this.RaisePropertyChanged("Withholding_Tax_Rate_Data");
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