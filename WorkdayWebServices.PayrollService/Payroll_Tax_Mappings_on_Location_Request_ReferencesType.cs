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
	public class Payroll_Tax_Mappings_on_Location_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payroll_Tax_Location_MappingObjectType[] payroll_Tax_Location_Mapping_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Tax_Location_Mapping_Reference", Order = 0)]
		public Payroll_Tax_Location_MappingObjectType[] Payroll_Tax_Location_Mapping_Reference
		{
			get
			{
				return this.payroll_Tax_Location_Mapping_ReferenceField;
			}
			set
			{
				this.payroll_Tax_Location_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Tax_Location_Mapping_Reference");
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
