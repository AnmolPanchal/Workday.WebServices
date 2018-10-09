using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Responsibility_Profile_for_Job_DataType : INotifyPropertyChanged
	{
		private string responsibilityField;

		private bool requiredField;

		private bool requiredFieldSpecified;

		private Skill_Qualification_EnabledObjectType qualification_Source_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Responsibility
		{
			get
			{
				return this.responsibilityField;
			}
			set
			{
				this.responsibilityField = value;
				this.RaisePropertyChanged("Responsibility");
			}
		}

		[XmlElement(Order = 1)]
		public bool Required
		{
			get
			{
				return this.requiredField;
			}
			set
			{
				this.requiredField = value;
				this.RaisePropertyChanged("Required");
			}
		}

		[XmlIgnore]
		public bool RequiredSpecified
		{
			get
			{
				return this.requiredFieldSpecified;
			}
			set
			{
				this.requiredFieldSpecified = value;
				this.RaisePropertyChanged("RequiredSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Skill_Qualification_EnabledObjectType Qualification_Source_Reference
		{
			get
			{
				return this.qualification_Source_ReferenceField;
			}
			set
			{
				this.qualification_Source_ReferenceField = value;
				this.RaisePropertyChanged("Qualification_Source_Reference");
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
