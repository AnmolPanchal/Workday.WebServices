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
	public class Course_Material_Section_Assignment_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Student_Course_MaterialObjectType student_Course_Material_ReferenceField;

		private bool course_Material_Section_Assignment_RequiredField;

		private bool course_Material_Section_Assignment_RequiredFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Course_MaterialObjectType Student_Course_Material_Reference
		{
			get
			{
				return this.student_Course_Material_ReferenceField;
			}
			set
			{
				this.student_Course_Material_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Material_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Course_Material_Section_Assignment_Required
		{
			get
			{
				return this.course_Material_Section_Assignment_RequiredField;
			}
			set
			{
				this.course_Material_Section_Assignment_RequiredField = value;
				this.RaisePropertyChanged("Course_Material_Section_Assignment_Required");
			}
		}

		[XmlIgnore]
		public bool Course_Material_Section_Assignment_RequiredSpecified
		{
			get
			{
				return this.course_Material_Section_Assignment_RequiredFieldSpecified;
			}
			set
			{
				this.course_Material_Section_Assignment_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Course_Material_Section_Assignment_RequiredSpecified");
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
