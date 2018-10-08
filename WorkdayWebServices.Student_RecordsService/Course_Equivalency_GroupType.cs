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
	public class Course_Equivalency_GroupType : INotifyPropertyChanged
	{
		private Course_Equivalency_GroupObjectType course_Equivalency_Group_ReferenceField;

		private Course_Equivalency_Group_DataType[] course_Equivalency_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Course_Equivalency_GroupObjectType Course_Equivalency_Group_Reference
		{
			get
			{
				return this.course_Equivalency_Group_ReferenceField;
			}
			set
			{
				this.course_Equivalency_Group_ReferenceField = value;
				this.RaisePropertyChanged("Course_Equivalency_Group_Reference");
			}
		}

		[XmlElement("Course_Equivalency_Group_Data", Order = 1)]
		public Course_Equivalency_Group_DataType[] Course_Equivalency_Group_Data
		{
			get
			{
				return this.course_Equivalency_Group_DataField;
			}
			set
			{
				this.course_Equivalency_Group_DataField = value;
				this.RaisePropertyChanged("Course_Equivalency_Group_Data");
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
