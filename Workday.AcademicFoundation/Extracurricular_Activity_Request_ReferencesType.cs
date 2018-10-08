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
	public class Extracurricular_Activity_Request_ReferencesType : INotifyPropertyChanged
	{
		private Extracurricular_ActivityObjectType[] extracurricular_Activity_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Extracurricular_Activity_Reference", Order = 0)]
		public Extracurricular_ActivityObjectType[] Extracurricular_Activity_Reference
		{
			get
			{
				return this.extracurricular_Activity_ReferenceField;
			}
			set
			{
				this.extracurricular_Activity_ReferenceField = value;
				this.RaisePropertyChanged("Extracurricular_Activity_Reference");
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