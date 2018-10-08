using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.CompensationService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Scorecard_Request_ReferencesType : INotifyPropertyChanged
	{
		private Default_ScorecardObjectType[] compensation_Scorecard_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Compensation_Scorecard_Reference", Order = 0)]
		public Default_ScorecardObjectType[] Compensation_Scorecard_Reference
		{
			get
			{
				return this.compensation_Scorecard_ReferenceField;
			}
			set
			{
				this.compensation_Scorecard_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Scorecard_Reference");
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
