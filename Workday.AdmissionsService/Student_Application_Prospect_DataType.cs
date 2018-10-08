using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.AdmissionsService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Application_Prospect_DataType : INotifyPropertyChanged
	{
		private StudentObjectType student_Prospect_ReferenceField;

		private Student_Application_Prospect_Subedit_DataType student_Application_Prospect_Subedit_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public StudentObjectType Student_Prospect_Reference
		{
			get
			{
				return this.student_Prospect_ReferenceField;
			}
			set
			{
				this.student_Prospect_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Application_Prospect_Subedit_DataType Student_Application_Prospect_Subedit_Data
		{
			get
			{
				return this.student_Application_Prospect_Subedit_DataField;
			}
			set
			{
				this.student_Application_Prospect_Subedit_DataField = value;
				this.RaisePropertyChanged("Student_Application_Prospect_Subedit_Data");
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
