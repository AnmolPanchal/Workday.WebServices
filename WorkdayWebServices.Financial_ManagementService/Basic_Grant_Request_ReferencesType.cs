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
	public class Basic_Grant_Request_ReferencesType : INotifyPropertyChanged
	{
		private GrantObjectType[] basic_Grant_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Basic_Grant_Reference", Order = 0)]
		public GrantObjectType[] Basic_Grant_Reference
		{
			get
			{
				return this.basic_Grant_ReferenceField;
			}
			set
			{
				this.basic_Grant_ReferenceField = value;
				this.RaisePropertyChanged("Basic_Grant_Reference");
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
