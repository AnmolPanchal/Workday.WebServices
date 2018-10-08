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
	public class Work_Schedule_Calendar_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Work_Schedule_Calendar_DataField;

		private bool include_Work_Schedule_Calendar_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Work_Schedule_Calendar_Data
		{
			get
			{
				return this.include_Work_Schedule_Calendar_DataField;
			}
			set
			{
				this.include_Work_Schedule_Calendar_DataField = value;
				this.RaisePropertyChanged("Include_Work_Schedule_Calendar_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Work_Schedule_Calendar_DataSpecified
		{
			get
			{
				return this.include_Work_Schedule_Calendar_DataFieldSpecified;
			}
			set
			{
				this.include_Work_Schedule_Calendar_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Work_Schedule_Calendar_DataSpecified");
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
