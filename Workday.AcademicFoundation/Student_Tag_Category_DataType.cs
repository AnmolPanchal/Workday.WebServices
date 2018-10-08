using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Academic_FoundationService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Tag_Category_DataType : INotifyPropertyChanged
	{
		private string student_Tag_Category_NameField;

		private Has_Academic_Unit_with_Shareable_Subordinates_DataType academic_Unit_Shareable_DataField;

		private bool student_Tag_Category_InactiveField;

		private bool student_Tag_Category_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Student_Tag_Category_Name
		{
			get
			{
				return this.student_Tag_Category_NameField;
			}
			set
			{
				this.student_Tag_Category_NameField = value;
				this.RaisePropertyChanged("Student_Tag_Category_Name");
			}
		}

		[XmlElement(Order = 1)]
		public Has_Academic_Unit_with_Shareable_Subordinates_DataType Academic_Unit_Shareable_Data
		{
			get
			{
				return this.academic_Unit_Shareable_DataField;
			}
			set
			{
				this.academic_Unit_Shareable_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Shareable_Data");
			}
		}

		[XmlElement(Order = 2)]
		public bool Student_Tag_Category_Inactive
		{
			get
			{
				return this.student_Tag_Category_InactiveField;
			}
			set
			{
				this.student_Tag_Category_InactiveField = value;
				this.RaisePropertyChanged("Student_Tag_Category_Inactive");
			}
		}

		[XmlIgnore]
		public bool Student_Tag_Category_InactiveSpecified
		{
			get
			{
				return this.student_Tag_Category_InactiveFieldSpecified;
			}
			set
			{
				this.student_Tag_Category_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Student_Tag_Category_InactiveSpecified");
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
