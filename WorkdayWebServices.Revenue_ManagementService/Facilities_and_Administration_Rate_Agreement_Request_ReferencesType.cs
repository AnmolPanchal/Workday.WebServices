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
	public class Facilities_and_Administration_Rate_Agreement_Request_ReferencesType : INotifyPropertyChanged
	{
		private Facilities_and_Admin_Rate_AgreementObjectType[] facilities_and_Administration_Rate_Agreement_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Facilities_and_Administration_Rate_Agreement_Reference", Order = 0)]
		public Facilities_and_Admin_Rate_AgreementObjectType[] Facilities_and_Administration_Rate_Agreement_Reference
		{
			get
			{
				return this.facilities_and_Administration_Rate_Agreement_ReferenceField;
			}
			set
			{
				this.facilities_and_Administration_Rate_Agreement_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Rate_Agreement_Reference");
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
