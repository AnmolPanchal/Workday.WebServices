using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Project_Billing_Rate_SheetType : INotifyPropertyChanged
	{
		private Project_Billing_Rate_SheetObjectType project_Billing_Rate_Sheet_ReferenceField;

		private Project_Billing_Rate_Sheet_DataType project_Billing_Rate_Sheet_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_Billing_Rate_SheetObjectType Project_Billing_Rate_Sheet_Reference
		{
			get
			{
				return this.project_Billing_Rate_Sheet_ReferenceField;
			}
			set
			{
				this.project_Billing_Rate_Sheet_ReferenceField = value;
				this.RaisePropertyChanged("Project_Billing_Rate_Sheet_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Project_Billing_Rate_Sheet_DataType Project_Billing_Rate_Sheet_Data
		{
			get
			{
				return this.project_Billing_Rate_Sheet_DataField;
			}
			set
			{
				this.project_Billing_Rate_Sheet_DataField = value;
				this.RaisePropertyChanged("Project_Billing_Rate_Sheet_Data");
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
