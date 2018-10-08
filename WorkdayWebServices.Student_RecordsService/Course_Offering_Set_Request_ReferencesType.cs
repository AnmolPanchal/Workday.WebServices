using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Student_RecordsService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Course_Offering_Set_Request_ReferencesType : INotifyPropertyChanged
	{
		private Course_Offering_SetObjectType[] course_Offering_Set_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Course_Offering_Set_Reference", Order = 0)]
		public Course_Offering_SetObjectType[] Course_Offering_Set_Reference
		{
			get
			{
				return this.course_Offering_Set_ReferenceField;
			}
			set
			{
				this.course_Offering_Set_ReferenceField = value;
				this.RaisePropertyChanged("Course_Offering_Set_Reference");
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
