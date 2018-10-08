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
	public class Put_Currency_Conversion_Rate_RequestType : INotifyPropertyChanged
	{
		private Currency_Conversion_RateObjectType currency_Conversion_Rate_ReferenceField;

		private Currency_Conversion_Rate_DataType currency_Conversion_Rate_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Currency_Conversion_RateObjectType Currency_Conversion_Rate_Reference
		{
			get
			{
				return this.currency_Conversion_Rate_ReferenceField;
			}
			set
			{
				this.currency_Conversion_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Conversion_Rate_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Currency_Conversion_Rate_DataType Currency_Conversion_Rate_Data
		{
			get
			{
				return this.currency_Conversion_Rate_DataField;
			}
			set
			{
				this.currency_Conversion_Rate_DataField = value;
				this.RaisePropertyChanged("Currency_Conversion_Rate_Data");
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