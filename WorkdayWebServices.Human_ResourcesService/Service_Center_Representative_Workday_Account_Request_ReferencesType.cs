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
	public class Service_Center_Representative_Workday_Account_Request_ReferencesType : INotifyPropertyChanged
	{
		private Service_Center_RepresentativeObjectType[] service_Center_Representative_Workday_Account_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Service_Center_Representative_Workday_Account_Reference", Order = 0)]
		public Service_Center_RepresentativeObjectType[] Service_Center_Representative_Workday_Account_Reference
		{
			get
			{
				return this.service_Center_Representative_Workday_Account_ReferenceField;
			}
			set
			{
				this.service_Center_Representative_Workday_Account_ReferenceField = value;
				this.RaisePropertyChanged("Service_Center_Representative_Workday_Account_Reference");
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
