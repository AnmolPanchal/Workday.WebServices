using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Student_FinanceService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Charge_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_ChargeObjectType[] student_Charge_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Charge_Reference", Order = 0)]
		public Student_ChargeObjectType[] Student_Charge_Reference
		{
			get
			{
				return this.student_Charge_ReferenceField;
			}
			set
			{
				this.student_Charge_ReferenceField = value;
				this.RaisePropertyChanged("Student_Charge_Reference");
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
