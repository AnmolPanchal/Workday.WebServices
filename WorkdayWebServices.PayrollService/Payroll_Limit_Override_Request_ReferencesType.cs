using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.PayrollService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Limit_Override_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payroll_Limit_OverrideObjectType[] payroll_Limit_Override_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Limit_Override_Reference", Order = 0)]
		public Payroll_Limit_OverrideObjectType[] Payroll_Limit_Override_Reference
		{
			get
			{
				return this.payroll_Limit_Override_ReferenceField;
			}
			set
			{
				this.payroll_Limit_Override_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Limit_Override_Reference");
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
