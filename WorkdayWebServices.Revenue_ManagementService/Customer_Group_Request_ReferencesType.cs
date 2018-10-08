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
	public class Customer_Group_Request_ReferencesType : INotifyPropertyChanged
	{
		private Customer_GroupObjectType[] customer_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Customer_Group_Reference", Order = 0)]
		public Customer_GroupObjectType[] Customer_Group_Reference
		{
			get
			{
				return this.customer_Group_ReferenceField;
			}
			set
			{
				this.customer_Group_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Group_Reference");
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
