using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WorkdayWebServices.Payroll_InterfaceService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_External_Payroll_Input_RequestType : INotifyPropertyChanged
	{
		private Payroll_InputObjectType external_Payroll_Input_ReferenceField;

		private External_Payroll_Input_DataType external_Payroll_Input_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_InputObjectType External_Payroll_Input_Reference
		{
			get
			{
				return this.external_Payroll_Input_ReferenceField;
			}
			set
			{
				this.external_Payroll_Input_ReferenceField = value;
				this.RaisePropertyChanged("External_Payroll_Input_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public External_Payroll_Input_DataType External_Payroll_Input_Data
		{
			get
			{
				return this.external_Payroll_Input_DataField;
			}
			set
			{
				this.external_Payroll_Input_DataField = value;
				this.RaisePropertyChanged("External_Payroll_Input_Data");
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