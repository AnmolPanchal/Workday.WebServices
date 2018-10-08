using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Financial_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class StatisticType : INotifyPropertyChanged
	{
		private StatisticObjectType statistic_ReferenceField;

		private Statistic_DataType statistic_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public StatisticObjectType Statistic_Reference
		{
			get
			{
				return this.statistic_ReferenceField;
			}
			set
			{
				this.statistic_ReferenceField = value;
				this.RaisePropertyChanged("Statistic_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Statistic_DataType Statistic_Data
		{
			get
			{
				return this.statistic_DataField;
			}
			set
			{
				this.statistic_DataField = value;
				this.RaisePropertyChanged("Statistic_Data");
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
