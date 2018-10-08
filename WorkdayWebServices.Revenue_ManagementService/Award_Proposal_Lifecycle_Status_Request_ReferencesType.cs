using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Proposal_Lifecycle_Status_Request_ReferencesType : INotifyPropertyChanged
	{
		private Award_Proposal_Lifecycle_StatusObjectType[] award_Proposal_Lifecycle_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Award_Proposal_Lifecycle_Status_Reference", Order = 0)]
		public Award_Proposal_Lifecycle_StatusObjectType[] Award_Proposal_Lifecycle_Status_Reference
		{
			get
			{
				return this.award_Proposal_Lifecycle_Status_ReferenceField;
			}
			set
			{
				this.award_Proposal_Lifecycle_Status_ReferenceField = value;
				this.RaisePropertyChanged("Award_Proposal_Lifecycle_Status_Reference");
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
