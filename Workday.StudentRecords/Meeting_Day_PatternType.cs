using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Meeting_Day_PatternType : INotifyPropertyChanged
	{
		private Meeting_Day_PatternObjectType meeting_Day_Pattern_ReferenceField;

		private Meeting_Day_Pattern_DataType[] meeting_Day_Pattern_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Meeting_Day_PatternObjectType Meeting_Day_Pattern_Reference
		{
			get
			{
				return this.meeting_Day_Pattern_ReferenceField;
			}
			set
			{
				this.meeting_Day_Pattern_ReferenceField = value;
				this.RaisePropertyChanged("Meeting_Day_Pattern_Reference");
			}
		}

		[XmlElement("Meeting_Day_Pattern_Data", Order = 1)]
		public Meeting_Day_Pattern_DataType[] Meeting_Day_Pattern_Data
		{
			get
			{
				return this.meeting_Day_Pattern_DataField;
			}
			set
			{
				this.meeting_Day_Pattern_DataField = value;
				this.RaisePropertyChanged("Meeting_Day_Pattern_Data");
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
