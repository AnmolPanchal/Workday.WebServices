using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Compensation_Commission_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private string commission_Plan_NameField;

		private Employee_Compensation_Commission_Plan_Assignment_Detail_DataType compensation_Element_Values_for_Commission_Plan_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Commission_Plan_Name
		{
			get
			{
				return this.commission_Plan_NameField;
			}
			set
			{
				this.commission_Plan_NameField = value;
				this.RaisePropertyChanged("Commission_Plan_Name");
			}
		}

		[XmlElement(Order = 1)]
		public Employee_Compensation_Commission_Plan_Assignment_Detail_DataType Compensation_Element_Values_for_Commission_Plan_Data
		{
			get
			{
				return this.compensation_Element_Values_for_Commission_Plan_DataField;
			}
			set
			{
				this.compensation_Element_Values_for_Commission_Plan_DataField = value;
				this.RaisePropertyChanged("Compensation_Element_Values_for_Commission_Plan_Data");
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