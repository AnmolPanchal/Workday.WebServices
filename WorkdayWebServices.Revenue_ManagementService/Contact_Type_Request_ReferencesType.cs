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
	public class Contact_Type_Request_ReferencesType : INotifyPropertyChanged
	{
		private Business_Entity_Contact_Type_TenantedObjectType[] contact_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Contact_Type_Reference", Order = 0)]
		public Business_Entity_Contact_Type_TenantedObjectType[] Contact_Type_Reference
		{
			get
			{
				return this.contact_Type_ReferenceField;
			}
			set
			{
				this.contact_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contact_Type_Reference");
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