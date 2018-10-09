using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Facilities_and_Admin_Object_Class_Mapping_Request_ReferencesType : INotifyPropertyChanged
	{
		private Facilities_and_Admin_Object_Class_MappingObjectType[] facilities_and_Admin_Object_Class_Mapping_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Facilities_and_Admin_Object_Class_Mapping_Reference", Order = 0)]
		public Facilities_and_Admin_Object_Class_MappingObjectType[] Facilities_and_Admin_Object_Class_Mapping_Reference
		{
			get
			{
				return this.facilities_and_Admin_Object_Class_Mapping_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Object_Class_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Object_Class_Mapping_Reference");
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
