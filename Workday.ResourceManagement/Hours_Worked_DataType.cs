using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Hours_Worked_DataType : INotifyPropertyChanged
	{
		private Time_Entry_CodeObjectType time_Code_ReferenceField;

		private decimal hoursField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Time_Entry_CodeObjectType Time_Code_Reference
		{
			get
			{
				return this.time_Code_ReferenceField;
			}
			set
			{
				this.time_Code_ReferenceField = value;
				this.RaisePropertyChanged("Time_Code_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Hours
		{
			get
			{
				return this.hoursField;
			}
			set
			{
				this.hoursField = value;
				this.RaisePropertyChanged("Hours");
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
